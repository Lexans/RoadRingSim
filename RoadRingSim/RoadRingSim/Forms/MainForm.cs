﻿using RoadRingSim.Data.DAO;
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

        private void AccManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAccountManager()).ShowDialog();
        }
    }
}
