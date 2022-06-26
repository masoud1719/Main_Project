using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    
    public partial class HorseShoeFrontPage : UserControl
    {
        private double mass;
        private double stroke;
        public HorseShoeFrontPage()
        {
            InitializeComponent();
        }
  
        
        
        private void HorseShoe_Click_1(object sender, EventArgs e)
        {

            MainForm.HorseShoe();

            if (comboBoxForce.SelectedIndex == 0)
            {
                lblForce.Text = "Kg";
            }
            else
            {
                lblForce.Text = "N";
            }
        }

        private void HorseShoe_c_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    

