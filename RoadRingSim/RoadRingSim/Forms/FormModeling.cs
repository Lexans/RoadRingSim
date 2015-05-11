using RoadRingSim.Core;
using RoadRingSim.Core.Domains;
using RoadRingSim.Data.DAO;
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
    public partial class FormModeling : Form
    {
        CrossRoad cr;
        bool isExtUser;

        public FormModeling(CrossRoad cr, bool isExtUser)
        {   InitializeComponent();

            Envirmnt.Reset();
            Render.Reset();

            this.cr = cr;
            this.isExtUser = isExtUser;
            Envirmnt.Inst.Cross = cr;
            Envirmnt.Inst.BuildMap();
            Envirmnt.Inst.InitObjectCreators();
            Render.Inst.Canvas = panel1.CreateGraphics();

            //задание законов распределения
            comboBoxCarLaw.SelectedIndex = (int)cr.DistribustionCars.Type-1;
            numericUpDownCarParam1.Value = (decimal)cr.DistribustionCars.Parametr1;
            numericUpDownCarParam2.Value = (decimal)cr.DistribustionCars.Parametr2;

            comboBoxHuman.SelectedIndex = (int)cr.DistributionHumans.Type - 1;
            numericUpDownHumParam1.Value = (decimal)cr.DistributionHumans.Parametr1;
            numericUpDownHumParam2.Value = (decimal)cr.DistributionHumans.Parametr2;


            if(!isExtUser)
            {
                groupBoxCar.Visible = false;
                groupBoxHuman.Visible = false;
            }

            Text = cr.Name;
 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Envirmnt.Inst.SimulationStep();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Render.Inst.DrawMap();
        }

        private void FormModeling_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 - trackBarSpeed.Value;
        }

        private void buttonPlayClick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonSetCars_Click(object sender, EventArgs e)
        {
            cr.DistribustionCars.Type = (DistrubutionLaws)(comboBoxCarLaw.SelectedIndex + 1);
            cr.DistribustionCars.Parametr1 = (double)numericUpDownCarParam1.Value;
            cr.DistribustionCars.Parametr2 = (double)numericUpDownCarParam2.Value;
        }

        private void buttonSetHums_Click(object sender, EventArgs e)
        {
            cr.DistributionHumans.Type = (DistrubutionLaws)(comboBoxHuman.SelectedIndex + 1);
            cr.DistributionHumans.Parametr1 = (double)numericUpDownHumParam1.Value;
            cr.DistributionHumans.Parametr2 = (double)numericUpDownHumParam2.Value;
        }
    }
}
