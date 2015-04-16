using RoadRingSim.Core.Domains;
using RoadRingSim.Model;
using RoadRingSim.Presenter;
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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            (new UserPresenter()).Init(this, new UserModel());
        }

        public event Action AddUser;
        public event Action<User> EditUser;
        public event Action<User> DeleteUser;

        public void ShowUserList(List<User> List)
        {
            userBindingSource.DataSource = List;
            userBindingSource.ResetBindings(false);
        }


        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current == null) return;
            if (EditUser != null)
                EditUser((User)userBindingSource.Current); //вызов события изменнеия
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (AddUser != null)
                AddUser();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current == null) return;
            if (EditUser != null)
                DeleteUser((User)userBindingSource.Current); //вызов события изменнеия
        }



    }
}
