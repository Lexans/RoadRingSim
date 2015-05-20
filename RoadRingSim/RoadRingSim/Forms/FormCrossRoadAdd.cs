using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadRingSim.Forms
{
    public partial class FormCrossRoadAdd : Form
    {
        CrossRoad obj;
        public FormCrossRoadAdd()
        {
            InitializeComponent();
        }
        public FormCrossRoadAdd(CrossRoad obj) : this()
        {
            CrossRoad = obj;
            Text = "Изменение перекрестка";
            buttonOk.Text = "Изменить";
        }
        private bool IsCheck()
        {
            bool ok = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                ok = false;
                errorProvider1.SetError(textBoxName, "Не задано название");
            }
            if (comboBoxCarLaw.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBoxCarLaw, "Не выбран закон распределения машин");
            }
            if (comboBoxHumanLaw.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBoxHumanLaw, "Не выбран закон распределения пешеходов");
            }
            if (comboBoxPriority.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBoxPriority, "Не выбран приоритет дорог");
            }
            return ok;
        }
        public CrossRoad CrossRoad
        {
            get
            {
                if (obj == null) obj = new CrossRoad();
                obj.SetPriority(comboBoxPriority.SelectedIndex);
                obj.DistribustionCars = new CrossRoadLaw(comboBoxCarLaw.SelectedIndex) { Parametr1 = (double)numericUpDownCarLawParam1.Value, Parametr2 = (double)numericUpDownCarLawParam2.Value };
                obj.DistributionHumans = new CrossRoadLaw(comboBoxHumanLaw.SelectedIndex) { Parametr1 = (double)numericUpDownHumanLawParam1.Value, Parametr2 = (double)numericUpDownHumanLawParam2.Value };
                obj.IsLights = checkBoxIsLight.Checked;
                obj.LightsTime = checkBoxIsLight.Checked ? (uint)numericUpDownTimeLightSwitch.Value : 1;
                obj.LinesHorisontal = (int)numericUpDownNumHorisontal.Value;
                obj.LinesRing = (int)numericUpDownNumRing.Value;
                obj.LinesVertical = (int)numericUpDownNumVertical.Value;
                obj.Name = textBoxName.Text;
                return obj;
            }
            set
            {
                this.obj = value;
                textBoxName.Text = obj.Name;
                comboBoxCarLaw.SelectedIndex = obj.DistribustionCars.GetIndexLaw();
                comboBoxHumanLaw.SelectedIndex = obj.DistributionHumans.GetIndexLaw();
                comboBoxPriority.SelectedIndex = obj.GetPriorityId();
                numericUpDownCarLawParam1.Value = (decimal)obj.DistribustionCars.Parametr1;
                numericUpDownCarLawParam2.Value = (decimal)obj.DistribustionCars.Parametr2;
                numericUpDownHumanLawParam1.Value = (decimal)obj.DistributionHumans.Parametr1;
                numericUpDownHumanLawParam2.Value = (decimal)obj.DistributionHumans.Parametr2;
                checkBoxIsLight.Checked = obj.IsLights;
                numericUpDownTimeLightSwitch.Enabled = checkBoxIsLight.Checked ? true : false;
                numericUpDownTimeLightSwitch.Value = obj.LightsTime;
                numericUpDownNumHorisontal.Value = obj.LinesHorisontal;
                numericUpDownNumRing.Value = obj.LinesRing;
                numericUpDownNumVertical.Value = obj.LinesVertical;
            }
        }

        private void checkBoxIsLight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsLight.Checked) numericUpDownTimeLightSwitch.Enabled = true;
            else numericUpDownTimeLightSwitch.Enabled = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (IsCheck())
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Найдена ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxCarLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCarLaw.SelectedIndex == 1) numericUpDownCarLawParam2.Enabled = false;
            else numericUpDownCarLawParam2.Enabled = true;
        }

        private void comboBoxHumanLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHumanLaw.SelectedIndex == 1) numericUpDownHumanLawParam2.Enabled = false;
            else numericUpDownHumanLawParam2.Enabled = true;
        }
    }
}
