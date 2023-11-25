using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Splash_screen : Form
    {
        Timer timer1;
        public Splash_screen()
        {
            InitializeComponent();
        }

        private void Splash_screen_Shown(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 900;
            timer1.Start();
            splash_timer.Enabled = true;
            timer1.Tick += timer1_click;
        }


        private void timer1_click(object sender, EventArgs e)
        {
            timer1.Stop();
            splash_timer.Enabled = false;
            Login_Page login = new Login_Page();
            this.Hide();
            login.Show();
        }

        private void Splash_progressBar_Click(object sender, EventArgs e)
        {

        }

        private void Splash_screen_Load(object sender, EventArgs e)
        {
            int i;
            Splash_progressBar.Minimum = 0;
            Splash_progressBar.Maximum = 200;
            for (i = 0; i <= 200; i++)
            {
                Splash_progressBar.Value = i;
            }
        }
       
    }
}
