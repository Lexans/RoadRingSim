﻿using System;
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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBoxLogin.Text)
                && !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}