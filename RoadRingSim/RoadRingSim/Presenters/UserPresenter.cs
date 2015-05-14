using RoadRingSim.Core.Domains;
using RoadRingSim.Forms;
using RoadRingSim.Models;
using System;
using System.Windows.Forms;

namespace RoadRingSim.Presenters
{
    public class UserPresenter
    {
        private FormAccountManager _form;
        private UserModel _model;

        //отсылает модель в форму
        public void Init(FormAccountManager form, UserModel model)
        {
            _form = form;
            _model = model;
            form.ShowUserList(model.Users);
            form.AddUser += new Action(form_AddUser);
            form.DeleteUser +=new Action<User>(form_DeleteUser);
            form.EditUser += new Action<User>(form_EditUser);
        }

        public void form_DeleteUser(User obj)
        {
            if (!_model.Users.Exists(x => (x.Role.ID == 1) && (x != obj)))
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранного пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _model.DeleteUser(obj);
                    _form.ShowUserList(_model.Users);
                }
            }
            else MessageBox.Show("Удаление последнего администратора невозможно!", "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void form_AddUser()
        {
            var f = new FormUserAdd();
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (!_model.Users.Exists(x => x.Login == f.User.Login))
                {
                    _model.AddUser(f.User);
                    _form.ShowUserList(_model.Users);
                }
                else MessageBox.Show("Пользователь с таким логином уже существует. Добавление было прервано.", "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void form_EditUser(User obj)
        {
            var f = new FormUserAdd(obj);
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (!_model.Users.Exists(x => (x.Login == f.User.Login) && (x != obj)))
                {
                    _model.EditUser(f.User);
                    _form.ShowUserList(_model.Users);
                }
                else MessageBox.Show("Пользователь с таким логином уже существует. Изменение было прервано.", "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}