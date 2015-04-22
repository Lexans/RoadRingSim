using System;
using System.Windows.Forms;

namespace RoadRingSim.Forms
{
    public partial class FormSplashscreen : Form
    {
        private int _tickCounter;

        public FormSplashscreen()
        {
            InitializeComponent();
        }

        private void FormSplashscreen_Load(object sender, EventArgs e)
        {
            _tickCounter = 0;
            timerSplashScreen.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tickCounter++;
            if (_tickCounter > 30)
            {
                timerSplashScreen.Stop();
                this.Close();
            }
        }

    }
}
