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
    public partial class FormAuth : Form
    {
        UserDAO uDAO;
        public FormAuth(UserDAO user)
        {
            InitializeComponent();
            uDAO = user;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxLogin.Text)
                && !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                uDAO.UserByLoginPassword(textBoxLogin.Text, textBoxPassword.Text);
                if (uDAO.CurentUser == null) MessageBox.Show("Неверные данные", "Ошибка");
                else DialogResult = DialogResult.OK;
            }
            
        }
    }
}
