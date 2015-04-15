using RoadRingSim.Core.Domains;
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
    public partial class FormAccountManager : Form
    {
        public FormAccountManager()
        {
            InitializeComponent();
            UserDAO Users = new UserDAO();
            List<User> list = Users.SelectAll();
            
            list.ForEach(x => listView1.Items.Add(new ListViewItem(new string[] {Convert.ToString(x.ID), x.Login, Convert.ToString(x.Role.ID)})));
            
            
        }
    }
}
