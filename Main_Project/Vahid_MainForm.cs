using Excitation_Coil;
using Main;
using second;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Image Green { get; private set; }

        internal static void openSmallTrans()
        {
            SmallTrans f = new SmallTrans();
            f.ShowDialog();
        }

        public Vahid_MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForn.Visible = false;
            button6.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForn.Visible = true;
                    button6.Visible = false;

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

            lblTitle.Text = "Home";
            

            panelDesktopPane.Controls.Clear();
            var homeFrontPage = new HomeFrontPage();
            homeFrontPage.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(homeFrontPage);
        }

        


 

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Excitation Coil";

            panelDesktopPane.Controls.Clear();
            var excitationCoilFrontPage = new excitationCoilFrontPage();
            excitationCoilFrontPage.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(excitationCoilFrontPage);
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
            
        }

        private void butFlatarmatur(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Flat Armature";
            

            panelDesktopPane.Controls.Clear();
            FlatArmitureFrontPage ar = new FlatArmitureFrontPage();
            ar.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ar);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Horse Shoe";
            
            panelDesktopPane.Controls.Clear();
            var h = new HorseShoeFrontPage();
            h.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(h);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Plunger";

            panelDesktopPane.Controls.Clear();
            PlungerFrontPage ar = new PlungerFrontPage();
            ar.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Single Phase Trans";

            panelDesktopPane.Controls.Clear();
            TransFrontPage ar = new TransFrontPage();
            ar.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); lblTitle.Text = "Three Phase Transs";

            panelDesktopPane.Controls.Clear();
            Trans2Frontpage ar = new Trans2Frontpage();
            ar.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ar);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ActivateButton(sender); lblTitle.Text = "Small Trans";
            

            panelDesktopPane.Controls.Clear();
            SmallTransFrontPage ar = new SmallTransFrontPage();
            ar.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(ar);
        }

        private void btnCloseChildForn_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            var browser = new WebBrowser();
            browser.Name = "web";
            browser.Url = new System.Uri("http://aut.ac.ir");
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(browser);
            

            if (activeForm != null)
            {
                activeForm.Close();
                
            }
           
            Rest();
           
        }

        private void Rest()
        {
            DisableButtn();
            lblTitle.Text = "";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForn.Visible = false;
            button6.Visible = true;
            
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var web = panelDesktopPane.Controls["web"];
            if (web == null)
                return;

            ((WebBrowser)(web)).Url = new Uri("http://varzesh3.com");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(76, 51, 51);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
    }




}

