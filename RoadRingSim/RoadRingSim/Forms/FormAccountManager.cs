using RoadRingSim.Core.Domains;
using RoadRingSim.Data.DAO;
using RoadRingSim.Models;
using RoadRingSim.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RoadRingSim.Forms
{
    public partial class FormAccountManager : Form
    {
        UserDAO user;
        UserPresenter up = new UserPresenter();
        public FormAccountManager(UserDAO user)
        {
            InitializeComponent();
            up.Init(this, new UserModel(user));
            this.user = user;
        }

        public event Action AddUser;
        public event Action<User> EditUser;
        public event Action<User> DeleteUser;

        public void ShowUserList(List<User> list)
        {
            userBindingSource.DataSource = list.OrderBy(x => x.Login);
            userBindingSource.ResetBindings(false);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (AddUser != null) AddUser();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current != null)
                if (EditUser != null)
                    EditUser((User)userBindingSource.Current);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current != null)
                if (DeleteUser != null)
                    DeleteUser((User)userBindingSource.Current);
        }
    }
}
