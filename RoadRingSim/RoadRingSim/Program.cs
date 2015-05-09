using RoadRingSim.Data.DAO;
using RoadRingSim.Forms;
using System;
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

            var auth = new Forms.FormAuth();

            if (auth.ShowDialog() == DialogResult.OK)
            {
                UserDAO user = auth.GetUser();
                Application.Run(new MainForm(user));
            }
            else return;
#endif
            Application.Run(new MainForm());
        }
    }
}
