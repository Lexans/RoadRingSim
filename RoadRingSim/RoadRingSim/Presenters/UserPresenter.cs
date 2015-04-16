using RoadRingSim.Core.Domains;
using RoadRingSim.Forms;
using RoadRingSim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadRingSim.Presenter
{
    class UserPresenter
    {
        private UserForm _form;
        private UserModel _model;

        //отсылает модель в форму
        public void Init(UserForm form, UserModel model)
        {
            form.ShowUserList(model.Users);
            //form.AddUser += new Action(model);
        }

        public void form_DeleteUser(User obj)
        {
            //тут сообщение подтверждения удаления

            _model.DeleteUser(obj);
            _form.ShowUserList(_model.Users);
        }

        public void form_Adduser()
        {
            var f = new AddUserForm();
            if(f.ShowDialog() == DialogResult.OK)
            {
                _model.EditUser(f.EditedUser);
                _form.ShowUserList(_model.Users);
            }
        }

    }
}
