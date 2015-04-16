using RoadRingSim.Core.Domains;
using RoadRingSim.Model;
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
    public partial class AddUserForm : Form
    {
        private User _user;

        //конструктор для создания юзера
        public AddUserForm()
        {
            InitializeComponent();

            userRoleBindingSource.DataSource = UserModel.Role;
            userRoleBindingSource.ResetBindings(false);
        }

        //конструктор изменения пользоателя
        public AddUserForm(User user): this()
        {
            EditedUser = user;
            Text = "Редактирование юзера";
        }

        private bool IsCheck()
        {
            var ok = true;
            errorProvider1.Clear();
            if(string.IsNullOrEmpty(textBoxLogin.Text))
            {
                ok = false;
                errorProvider1.SetError(textBoxLogin, "не задан логин");
            }

            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                ok = false;
                errorProvider1.SetError(textBoxPassword, "не задан password");
            }

            return ok;
        }

        //свойство задания текщего редактируемого юзера
        public User EditedUser
        {
            get
            {
                if (_user == null) _user = new User();

                _user.Login = textBoxLogin.Text;
                _user.Password = textBoxPassword.Text;
                _user.Role = (UserRole)userRoleBindingSource.Current;
                return _user;
            }
            set
            {
                textBoxLogin.Text = _user.Login;
                textBoxPassword.Text = _user.Password;
                userRoleBindingSource.Position = userRoleBindingSource.IndexOf(_user.Role);
                _user = value;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (IsCheck())
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("найдена ошибка");


        }

    }
}
