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

        internal static void openTrans2()
        {
            Trans2 f = new Trans2();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(new HorseShoeFrontPage());
        }

        internal static void HorseShoe()
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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
            HomeFrontPage h = new HomeFrontPage();
            h.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(h);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var homeFrontPage = new HomeFrontPage();
            homeFrontPage.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(homeFrontPage);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var transFrontPage = new TransFrontPage();
            transFrontPage.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(transFrontPage);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FlatArmitureFrontPage ar = new FlatArmitureFrontPage();
            ar.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(ar);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var h = new HorseShoeFrontPage();
            h.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(h);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var p = new PlungerFrontPage();
            p.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            var excitationCoilFrontPage = new excitationCoilFrontPage();
            excitationCoilFrontPage.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(excitationCoilFrontPage);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            var trans2Frontpage = new Trans2Frontpage();
            trans2Frontpage.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(trans2Frontpage);
        }
    }
}