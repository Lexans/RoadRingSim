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

            var auth = new Forms.AuthForm();
            if (auth.ShowDialog() == DialogResult.OK)
            {
                (new Forms.FormMain()).Show();
            }
        }
    }
}
