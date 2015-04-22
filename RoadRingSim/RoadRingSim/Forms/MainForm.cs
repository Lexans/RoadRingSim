using RoadRingSim.Core;
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
    public partial class MainForm : Form
    {
        UserDAO user;
        public MainForm(UserDAO user)
        {
            InitializeComponent();
            this.user = user;
            if (user.CurentUser.Role.ID == 3) AccManagerToolStripMenuItem.Enabled = true;
        }

        public MainForm()
        {
            InitializeComponent();

        }

        private void AccManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAccountManager()).ShowDialog();
        }




        private void StartModeling()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Envirmnt.Inst.SimulationStep();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CrossRoadDAO crd = new CrossRoadDAO();
            Envirmnt.Inst.Cross = crd.SelectByID(1);
            Envirmnt.Inst.BuildMap();
            Envirmnt.Inst.InitObjectCreators();

            Render.Inst.Canvas = panel1.CreateGraphics();
            Render.Inst.DrawMap();

            timer1.Start();
        }

    }
}
