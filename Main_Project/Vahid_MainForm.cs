using Excitation_Coil;
using Main;
using second;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testmna;
using trans_1;

namespace Main_Project
{
    public partial class Vahid_MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Vahid_MainForm()
        {
            InitializeComponent();
            random = new Random();

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButtn();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Bell MT", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }


        private void DisableButtn()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if ( activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }








        private void button2_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            panelDesktopPane.Controls.Add(new HorseShoeFrontPage());
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
            panelDesktopPane.Controls.Clear();
            panelDesktopPane.Controls.Add(new excitationCoilFrontPage());
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            panelDesktopPane.Controls.Add(new FlatArmitureFrontPage());

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
                        Plunger f = new Plunger(force, stroke, isMass);
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










        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            var homeFrontPage = new HomeFrontPage();
            homeFrontPage.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(homeFrontPage);
        }

        private void butFlatarmatur_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            FlatArmitureFrontPage ar = new FlatArmitureFrontPage();
            ar.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            var h = new HorseShoeFrontPage();
            h.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(h);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            var p = new PlungerFrontPage();
            p.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(p);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            var excitationCoilFrontPage = new excitationCoilFrontPage();
            excitationCoilFrontPage.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(excitationCoilFrontPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            var transFrontPage = new TransFrontPage();
            transFrontPage.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(transFrontPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panelDesktopPane.Controls.Clear();
            var trans2Frontpage = new Trans2Frontpage();
            trans2Frontpage.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(trans2Frontpage);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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

        internal static void openTrans2()
        {
            Trans2 f = new Trans2();
            f.ShowDialog();
        }

        private void Vahid_MainForm_Load(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            HomeFrontPage h = new HomeFrontPage();
            h.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(h);
        }
    }




}

