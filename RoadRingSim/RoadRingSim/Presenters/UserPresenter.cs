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
            if (MessageBox.Show("Вы действительно хотите удалить выбранного пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _model.DeleteUser(obj);
                _form.ShowUserList(_model.Users);
            }
        }

        public void form_AddUser()
        {
            var f = new FormUserAdd();
            if (f.ShowDialog() == DialogResult.OK)
            {
                _model.AddUser(f.GetUser());
                _form.ShowUserList(_model.Users);
            }
        }
        public void form_EditUser(User obj)
        {
            var f = new FormUserAdd(obj);
            if (f.ShowDialog() == DialogResult.OK)
            {
                _model.EditUser(f.GetUser());
                _form.ShowUserList(_model.Users);
            }
        }
    }
}