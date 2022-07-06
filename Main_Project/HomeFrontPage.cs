using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class HomeFrontPage : UserControl
    {

        Timer timer = new Timer();

        public HomeFrontPage()
        {
            InitializeComponent();

            
            label33.Text = DateTime.Now.ToString("yyyy/MM/dd");//tarikh feli ro mide
            label37.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 800;
            timer.Start();






        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://emtrl.aut.ac.ir/");
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            label37.Text = DateTime.Now.ToString("HH:mm:ss tt");//zaman ro mide
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
