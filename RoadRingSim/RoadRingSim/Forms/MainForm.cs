using RoadRingSim.Core;
using RoadRingSim.Core.Domains;
using RoadRingSim.Data.DAO;
using RoadRingSim.Models;
using RoadRingSim.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RoadRingSim.Forms
{
    public partial class MainForm : Form
    {
        CrossRoadDAO crDAO;
        CrossRoadPresenter up = new CrossRoadPresenter();
        UserDAO user;

        public MainForm(UserDAO user)
        {
            InitializeComponent();
#if !DEBUG
            this.user = user;
            if (this.user.currentUser.Role.ID == 1) AccManagerToolStripMenuItem.Enabled = true;
#else
            this.user = new UserDAO() { currentUser = new User() { Role = new UserRole(1) } };
            AccManagerToolStripMenuItem.Enabled = true;
#endif
            crDAO = new CrossRoadDAO();
            up.Init(this, new CrossRoadModel(crDAO));
        }

        private void AccManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAccountManager(user)).ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new FormAbout()).ShowDialog();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAuthor()).ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public event Action AddItem;
        public event Action<CrossRoad> EditItem;
        public event Action<CrossRoad> DeleteItem;

        public void ShowCrossRoadList(List<CrossRoad> list)
        {
            crossRoadBindingSourceCr.DataSource = list;
            crossRoadBindingSourceCr.ResetBindings(false);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (AddItem != null) AddItem();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (crossRoadBindingSourceCr.Current != null)
                if (EditItem != null)
                    EditItem((CrossRoad)crossRoadBindingSourceCr.Current);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (crossRoadBindingSourceCr.Current != null)
                if (DeleteItem != null)
                    DeleteItem((CrossRoad)crossRoadBindingSourceCr.Current);
        }
        private void mouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            crossRoadBindingSourceCr.Position = e.RowIndex;
        }

        private void toolStripButtonRun_Click(object sender, EventArgs e)
        {
            if (crossRoadBindingSourceCr.Current != null)
                if (DeleteItem != null)
                    new FormModeling((CrossRoad)crossRoadBindingSourceCr.Current,
                        (this.user == null || this.user.currentUser.Role.ID <= 1)
                        ).ShowDialog();

            up.Init(this, new CrossRoadModel(crDAO));
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RoadRingSimHelp.chm");
        }
    }
}
