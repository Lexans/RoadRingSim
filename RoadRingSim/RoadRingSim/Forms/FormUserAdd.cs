using RoadRingSim.Core.Domains;
using RoadRingSim.Models;
using System;
using System.Windows.Forms;

namespace RoadRingSim.Forms
{
    public partial class FormUserAdd : Form
    {
        private User _user;
        public FormUserAdd()
        {
            InitializeComponent();

            userRoleBindingSource.DataSource = UserModel.Role;
            userRoleBindingSource.ResetBindings(false);
        }

        public FormUserAdd(User user) : this()
        {
            SetUser(user);
            Text = "Редактирование пользователя";
            buttonOk.Text = "Изменить";
        }

        private bool IsCheck()
        {
            bool ok = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                ok = false;
                errorProvider1.SetError(textBoxLogin, "Не задан пароль");
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                ok = false;
                errorProvider1.SetError(textBoxPassword, "Не задан пароль");
            }
            return ok;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (IsCheck())
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Найдена ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public User GetUser()
        {
            if (_user == null) _user = new User();
            _user.Login = textBoxLogin.Text;
            _user.Password = textBoxPassword.Text;
            _user.Role = (UserRole)userRoleBindingSource.Current;
            return _user;
        }
        public void SetUser(User user)
        {
            _user = user;
            textBoxLogin.Text = _user.Login;
            textBoxPassword.Text = _user.Password;
            userRoleBindingSource.Position = user.Role.ID - 1;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
