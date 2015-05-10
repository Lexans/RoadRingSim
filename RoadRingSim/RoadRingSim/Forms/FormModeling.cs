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
    }
}
