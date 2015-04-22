using RoadRingSim.Data.DAO;
using System;
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
#if !DEBUG
            if (this.user.currentUser.Role.ID == 1) AccManagerToolStripMenuItem.Enabled = true;
#else 
            AccManagerToolStripMenuItem.Enabled = true;
#endif
        }

        private void AccManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAccountManager(user)).ShowDialog();
        }
    }
}
