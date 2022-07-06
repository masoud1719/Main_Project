using Main_Project;
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
        

        private void HorseShoe_c_Click(object sender, EventArgs e)
        {
            getValues();
            double indexNumber = Math.Sqrt(mass) / stroke;
            bool isMass = comboBoxForce.SelectedIndex == 0;
            Vahid_MainForm.openForm(indexNumber, Type.HorseShoe, mass, stroke * 100, isMass);
        }

        private void getValues()
        {
            {
                mass = Double.Parse(txtForce.Text);
                if (comboBoxForce.SelectedIndex == 1)
                {
                    mass /= 9.81;
                }

                stroke = Double.Parse(txtStroke.Text);
                stroke *= Math.Pow(10, -2);
            }
        }

        private void HorseShoeFrontPage_Load(object sender, EventArgs e)
        {
            comboBoxForce.SelectedIndex = 0;
        }

        private void comboBoxForce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForce.SelectedIndex == 0)
            {
                lblForce.Text = "Kg";
            }
            else
            {
                lblForce.Text = "N";
            }
        }

        private void txtForce_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForce_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStroke_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    

