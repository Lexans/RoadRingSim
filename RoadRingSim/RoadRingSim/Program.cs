using RoadRingSim.Data.DAO;
using RoadRingSim.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadRingSim
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if !DEBUG
            FormSplashscreen fs = new FormSplashscreen();
            fs.ShowDialog();

            UserDAO user = new UserDAO();
            var auth = new Forms.FormAuth(user);
            if (auth.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(user));
            }
#endif

            Application.Run(new MainForm());
        }
    }
}
