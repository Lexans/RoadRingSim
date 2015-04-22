using RoadRingSim.Data.DAO;
using System;
using System.Windows.Forms;

namespace RoadRingSim.Forms
{
    public partial class FormAuth : Form
    {
        UserDAO user = new UserDAO();
        public FormAuth()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxLogin.Text)
                && !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                user.UserByLoginPassword(textBoxLogin.Text, textBoxPassword.Text);
                if (user == null) MessageBox.Show("Неверные данные", "Ошибка");
                else DialogResult = DialogResult.OK;
            }
            
        }
        public UserDAO GetUser()
        {
            return user;
        }
    }
}
