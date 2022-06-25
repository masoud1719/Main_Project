using System;
using System.Windows.Forms;
using Excitation_Coil;
using Main_Project;
using second;
using testmna;
using trans_1;

namespace Main
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new FlatArmitureFrontPage());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new HorseShoeFrontPage());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new PlungerFrontPage());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new excitationCoilFrontPage());
        }

        public static void openForm(double indexNumber, Type problemType, double force, double stroke, bool isMass)
        {
           
            if (problemType == Type.FlatArmature)
            {
                if (indexNumber >= 7500)
                {
                    DialogResult dialogResult = MessageBox.Show("Good Choice", "Some Title", MessageBoxButtons.OK);
                    FlatArmature f = new FlatArmature(force, stroke, isMass);
                    f.ShowDialog();
                }
                else if (indexNumber < 7500)
                {
                    DialogResult dialogResult = MessageBox.Show("bad Choice plunger should be chosen", "Some Title", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        Plunger f = new Plunger(force,stroke, isMass);
                        f.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        FlatArmature f = new FlatArmature(force, stroke, isMass);
                        f.ShowDialog();
                    }
                   
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("bad Choice HorseShoe should be chosen", "Some Title", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        HorseShoe h = new HorseShoe(force, stroke, isMass);
                        h.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        FlatArmature f = new FlatArmature(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    
                }


            }
            else if (problemType == Type.HorseShoe)
            {
                if (indexNumber >= 200 && indexNumber < 20000)
                {
                    DialogResult dialogResult = MessageBox.Show("Good Choice", "Some Title", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        HorseShoe h = new HorseShoe(force, stroke, isMass);
                        h.ShowDialog();
                    }
                 
                }
                else if (indexNumber < 200)
                {
                    DialogResult dialogResult = MessageBox.Show("bad Choice Plunger should be chosen", "Some Title", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        Plunger f = new Plunger(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        HorseShoe h = new HorseShoe(force, stroke, isMass);
                        h.ShowDialog();
                    }
                    
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("bad Choice FlatArmature should be chosen", "Some Title", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        FlatArmature f = new FlatArmature(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        HorseShoe h = new HorseShoe(force, stroke, isMass);
                        h.ShowDialog();
                    }
                
                }

            }
            else if (problemType == Type.Plunger)
            {
                if (indexNumber > 1400 && indexNumber < 7500)
                {
                    DialogResult dialogResult = MessageBox.Show("Good Choice", "Some Title", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        Plunger f = new Plunger(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    
                }
                else if (indexNumber > 7500)
                {
                    DialogResult dialogResult = MessageBox.Show("bad Choice FlatArmature should be chosen", "Some Title", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        FlatArmature f = new FlatArmature(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        Plunger f = new Plunger(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("bad Choice HorseShoe should be chosen", "Some Title", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        HorseShoe h = new HorseShoe(force, stroke, isMass);
                        h.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        Plunger f = new Plunger(force, stroke, isMass);
                        f.ShowDialog();
                    }
                    
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new HomeFrontPage());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new HomeFrontPage());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new TransFrontPage());
        }

        public static void openTrans()
        {
            SinglePhaseTransformer f = new SinglePhaseTransformer();
            f.ShowDialog();
        }

        public static void openExcitationCoil()
        {
            Exsitationcoil f = new Exsitationcoil();
            f.ShowDialog();
        }
    }
}