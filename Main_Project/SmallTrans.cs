using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{





    public partial class SmallTrans : Form
    {





        private double rating;

        private double voltagePerTurn;

        private double highVoltage;

        private double lowVoltage;

        private double frequency;

        private double fluxDensity;

        private double delta;

        private double temperatureRise;

        private double ambTemperature;

        private double Wi;

        private double Ai;

        private double GiPerGcu;

        private double lmtPerLi;

        private double gcuPergi;

        private double CiPerCcu;

        private double x;

        private double DPera;

        private double AcuPerAi;

        private double ks;

        private double kc;

        private double kw;

        private double kFactor;

        private double sf;

        private double DiHv;

        private double DoHv;

        private double DiLv;

        private double DoLv;

        private double b0;

        private double bhv;

        private double blv;

        private double hc;

        private double w;

        private double n;

        private double y;

        private double Wcu;

        private double pho2;

        private double WiT;

        private double WcuT;

        private double SLL;

        private double Lmt;

        private double H;

        private double Hw;

        private double Hy;

        private double W;

        private double Ww;

        private double D;

        private double Dy;

        private double Aw;

        private double a;

        private double b;

        private double d;

        private double diLv;

        private double diHv;

        private double ILv;

        private double Iv;

        private double NLv;

        private double NHv;

        private double IHv;

        private double RHv;

        private double RLv;

        private double xHv;

        private double xLv;

        private double XLv;

        private double XHv;

        private double aHv;

        private double aLv;

        private double εx;

        private double dLv;

        private double dHv;

        private double XHv_2n;

        private double XLv_2n;

        private double Acu;






        private double Np;

        private double Voltadreg;

        private double Efficiency;






        private int SWGAWGBWGIndexHv = -1;
        private int SWGAWGBWGIndexLv = -1;

        private List<double> swgInsulations = new List<double>();
        private List<double> awgInsulations = new List<double>();



        private void cretwAWGInsulation()
        {


            for (int i = 0; i < 10; i++)
            {
                awgInsulations.Add(0.41);
            }

            awgInsulations.Add(0.4);

            awgInsulations.Add(0.4);

            awgInsulations.Add(0.4);

            awgInsulations.Add(0.35);

            awgInsulations.Add(0.35);

            awgInsulations.Add(0.35);

            awgInsulations.Add(0.35);

            awgInsulations.Add(0.3);

            awgInsulations.Add(0.3);

            awgInsulations.Add(0.3);

            awgInsulations.Add(0.3);

            awgInsulations.Add(0.3);

            awgInsulations.Add(0.3);



            for (int i = 23; i < 37; i++)
            {
                awgInsulations.Add(0.25);
            }

            for (int i = 37; i < 41; i++)
            {
                awgInsulations.Add(0.2);
            }
        }

        private void creteSWGInsulations()
        {
            for (int i = 0; i < 16; i++)
            {

                swgInsulations.Add(0.074);

            }

            swgInsulations.Add(0.075);

            swgInsulations.Add(0.075);

            swgInsulations.Add(0.075);

            swgInsulations.Add(0.263);

            swgInsulations.Add(0.263);

            swgInsulations.Add(0.05);

            swgInsulations.Add(0.05);

            swgInsulations.Add(0.038);

            swgInsulations.Add(0.038);

            swgInsulations.Add(0.038);

            swgInsulations.Add(0.038);

            swgInsulations.Add(0.033);

            swgInsulations.Add(0.033);

            swgInsulations.Add(0.033);

            swgInsulations.Add(0.025);

            swgInsulations.Add(0.025);

            swgInsulations.Add(0.025);

            swgInsulations.Add(0.025);

            swgInsulations.Add(0.018);

            swgInsulations.Add(0.018);

            swgInsulations.Add(0.018);

            swgInsulations.Add(0.018);

            swgInsulations.Add(0.018);

            swgInsulations.Add(0.013);

            swgInsulations.Add(0.013);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            wireGauge.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }









        public SmallTrans()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            getvalues();

            

            if (combo_Kw.SelectedIndex == 1)
            {
                if (rating <= 10000)
                {
                    kw = 8 / (30 + highVoltage);
                }
                else if (rating <= 50000 && rating > 10000)
                {
                    //  10 < S < 50
                    kw = 9 / (30 + highVoltage);
                }
                else if (rating <= 200000 && rating > 50000)
                {
                    //  50 < S < 200
                    kw = 10 / (30 + highVoltage);
                }
                else if (rating <= 500000 && rating > 200000)
                {
                    //  200 < S < 500
                    kw = 11 / (30 + highVoltage);
                }
                else if (rating <= 1000000 && rating > 500000)
                {
                    //  500 < S < 1000
                    kw = 12 / (30 + highVoltage);
                }
                else if (rating <= 2000000 && rating > 1000000)
                {
                    //  1000 < S < 2000
                    kw = 13 / (30 + highVoltage);
                }
                else if (rating <= 5000000 && rating > 2000000)
                {
                    //  2000 < S < 5000
                    kw = 14 / (30 + highVoltage);
                }

                else if (rating <= 10000000 && rating > 5000000)
                {
                    //  5000 < S < 10000
                    kw = 15 / (30 + highVoltage);
                }
                else if (rating <= 20000000 && rating > 10000000)
                {
                    //  10000 < S < 2000
                    kw = 16 / (30 + highVoltage);
                }
                else if (rating > 20000000)
                {
                    //  10000 < S < 2000
                    kw = 20 / (30 + highVoltage);
                }


            }


            




            if (rating <= 200)
            {
                maskedTextBox1.Text = "0.8";

            }
            else if (rating > 200 && rating <= 500)
            {
                maskedTextBox1.Text = "0.9";

            }
            else if (rating > 500 && rating <= 1000)
            {
                maskedTextBox1.Text = "1.0";

            }
            else if (rating > 1000 && rating <= 2000)
            {
                maskedTextBox1.Text = "1.1";

            }
            else if (rating > 2000 && rating <= 4000)
            {
                maskedTextBox1.Text = "1.2";

            }
            else
            {
                maskedTextBox1.Text = "1.25";

            }


            kFactor = Double.Parse(maskedTextBox1.Text);



            if (rating <= 50)
            {
                txt_delta.Text = "4.0";

            }
            else if (rating > 50 && rating <= 100)
            {
                txt_delta.Text = "3.5";

            }
            else if (rating > 100 && rating <= 200)
            {
                txt_delta.Text = "3.0";

            }
            else if (rating > 200 && rating <= 500)
            {
                txt_delta.Text = "2.5";

            }
            else if (rating > 500 && rating <= 1000)
            {
                txt_delta.Text = "2.0";

            }
            else if (rating > 1000 && rating <= 2000)
            {
                txt_delta.Text = "1.75";

            }
            else if (rating > 2000 && rating <= 3000)
            {
                txt_delta.Text = "1.5";

            }
            else if (rating > 3000 && rating <= 4000)
            {
                txt_delta.Text = "1.0";

            }
            else
            {
                txt_delta.Text = "0.85";

            }



            delta = Double.Parse(txt_delta.Text);



            if (rating <= 5)
            {

                maskvoltreg.Text = "20";
            }
            else if (rating > 5 && rating <= 10)
            {

                maskvoltreg.Text = "17";
            }
            else if (rating > 10 && rating <= 25)
            {

                maskvoltreg.Text = "15";
            }
            else if (rating > 25 && rating <= 50)
            {

                maskvoltreg.Text = "12";
            }
            else if (rating > 50 && rating <= 75)
            {

                maskvoltreg.Text = "10";
            }
            else if (rating > 75 && rating <= 100)
            {

                maskvoltreg.Text = "9";
            }
            else if (rating > 100 && rating <= 150)
            {

                maskvoltreg.Text = "8"; ;
            }
            else if (rating > 150 && rating <= 200)
            {

                maskvoltreg.Text = "7.5";
            }
            else if (rating > 200 && rating <= 300)
            {

                maskvoltreg.Text = "7";
            }
            else if (rating > 300 && rating <= 400)
            {

                maskvoltreg.Text = "6.5";
            }
            else if (rating > 400 && rating <= 500)
            {

                maskvoltreg.Text = "6";
            }
            else if (rating > 500 && rating <= 750)
            {

                maskvoltreg.Text = "5";
            }
            else if (rating > 750 && rating <= 1000)
            {

                maskvoltreg.Text = "4";
            }
            else if (rating > 1000 && rating <= 1500)
            {

                maskvoltreg.Text = "3";
            }
            else if (rating > 1500 && rating <= 2000)
            {

                maskvoltreg.Text = "2";
            }
            else if (rating > 2000 && rating <= 3000)
            {

                maskvoltreg.Text = "1.5";
            }
            else
            {

                maskvoltreg.Text = "1.5";
            }

            Voltadreg = Double.Parse(maskvoltreg.Text);







            if (rating <= 30)
            {
                maskEff.Text = "86.4";

            }
            else if (rating > 30 && rating <= 50)
            {
                maskEff.Text = "87.6";

            }
            else if (rating > 50 && rating <= 100)
            {
                maskEff.Text = "89.6";

            }
            else if (rating > 100 && rating <= 150)
            {
                maskEff.Text = "90.9";

            }
            else if (rating > 150 && rating <= 200)
            {
                maskEff.Text = "91.3";

            }
            else if (rating > 200 && rating <= 300)
            {
                maskEff.Text = "92.3";

            }
            else if (rating > 300 && rating <= 500)
            {
                maskEff.Text = "93";

            }
            else if (rating > 500 && rating <= 750)
            {
                maskEff.Text = "93.5";

            }
            else if (rating > 750 && rating <= 1000)
            {
                maskEff.Text = "94";

            }
            else
            {
                maskEff.Text = "94";

            }



            Efficiency = Double.Parse(maskEff.Text);





            Ai = kFactor * Math.Sqrt(rating);



            voltagePerTurn = kFactor * Math.Sqrt(rating / 1000);


            // سطح خالص  cm^2
            

            // سطح ناخالص

            double Agi;
            double d;
            double aE;
            double bE;
            double cE;
            double eE;
            double fE;
            double De;
            double SSFhv;
            double SSFlv;
            double EI;


            Agi = Ai / ks;



            d = Math.Sqrt(Agi) * 10;

            if (d < 10)
            {
                d = 10;
            }

            else if (d > 50)
            {
                d = 50;
            }


            else
            {

                if (d >= 10 && d < 11)
                {
                    d = 10;
                    EI = 30;

                }
                else if (d >= 11 && d < 13)
                {
                    d = 12;
                    EI = 36;

                }
                else if (d >= 13 && d < 15)
                {
                    d = 14;
                    EI = 42;

                }
                else if (d >= 15 && d < 17)
                {
                    d = 16;
                    EI = 48;

                }
                else if (d >= 17 && d < 19)
                {
                    d = 18;
                    EI = 54;

                }
                else if (d >= 19 && d < 21)
                {
                    d = 20;
                    EI = 60;

                }
                else if (d >= 21 && d < 23.56)
                {
                    d = 22;
                    EI = 66;

                }
                else if (d >= 23.56 && d < 25.56)
                {
                    d = 26;
                    EI = 78;

                }
                else if (d >= 25.56 && d < 27)
                {
                    d = 26;
                    EI = 78;

                }
                else if (d >= 27 && d < 30)
                {
                    d = 28;
                    EI = 84;

                }
                else if (d >= 30 && d < 35.56)
                {
                    d = 32;
                    EI = 96;

                }
                else if (d >= 35.56 && d < 38)
                {
                    d = 36;
                    EI = 108;

                }
                else if (d >= 38 && d < 43)
                {
                    d = 40;
                    EI = 120;

                }
                else if (d >= 43 && d < 47.56)
                {
                    d = 45;
                    EI = 135;

                }
                else if (d >= 47.56 && d < 50)
                {
                    d = 50;
                    EI = 150;

                }





            }


            aE = d * 3;
            bE = d / 2;
            cE = bE;
            eE = 3 * bE;
            fE = 2 * d;



            Aw = cE * eE;



            H = fE + b;
            W = aE;
            Hw = eE;
            Ww = cE;
            Hy = bE;
            D = (d / 2) + (1.5 * cE);
            Dy = Agi * 100 / d;



















            // volt
            Np = (1 / (4.44 * frequency * fluxDensity * Ai)) * 10000;





            


            



            



            double e1;
            double e2;


            e1 = highVoltage * (1 - (Voltadreg / 100));

            e2 = lowVoltage * (1 - (Voltadreg / 100));


            NHv = Np * e1;

            NLv = Np * e2;






            







            




            double VA1;
            double VA2;

            VA1 = rating / (Efficiency / 100);



            IHv = VA1 / highVoltage;

            aHv = IHv / delta;

            dHv = 1.13 * Math.Sqrt(aHv);


            double fileD;
            if (wireGauge.SelectedIndex == 0)
            {
                fileD = getDFromFile(@"Resources\\SWG.txt", dHv, true);
            }
            else if (wireGauge.SelectedIndex == 1)
            {
                fileD = getDFromFile(@"Resources\\AWG.txt", dHv, true);
            }
            else
            {
                fileD = getDFromFile(@"Resources\\BWG.txt", dHv, true);
            }



            double plus = 0.2;
            if (wireGauge.SelectedIndex == 0 || wireGauge.SelectedIndex == 1)
            {
                plus = swgInsulations[SWGAWGBWGIndexHv];
            }

            diHv = (fileD) + plus;


            double Requiredspaceforprimary;
            double Spacerequiredforsecondary;


            SSFhv = 0.8 * ((dHv * dHv) / (diHv * diHv));

            Requiredspaceforprimary = (NHv * aHv) / SSFhv;






            VA2 = rating / (Efficiency / 100);



            ILv = VA2 / lowVoltage;

            aLv = IHv / delta;

            dLv = 1.13 * Math.Sqrt(aLv);


            if (wireGauge.SelectedIndex == 0)
            {
                fileD = getDFromFile(@"Resources\\SWG.txt", dLv, false);
            }
            else if (wireGauge.SelectedIndex == 1)
            {
                fileD = getDFromFile(@"Resources\\AWG.txt", dLv, false);
            }
            else
            {
                fileD = getDFromFile(@"Resources\\BWG.txt", dLv, false);
            }




            if (wireGauge.SelectedIndex == 0 || wireGauge.SelectedIndex == 1)
            {
                plus = swgInsulations[SWGAWGBWGIndexLv];
            }

            diLv = (fileD) + plus;


            SSFlv = 0.8 * ((dLv * dLv) / (diLv * diLv));

            Spacerequiredforsecondary = (NLv * aLv) / SSFlv;




            // ohm_cmm
            double pho = 2.1e-6;
            double RT1 = 234.5 + 75;
            double RT2 = 234.5 + (temperatureRise + ambTemperature);
            pho2 = pho / (RT1 / RT2);





            if (checkBox1.Checked)
            {
                Lmt = Math.PI * (DoHv + DiLv) / 2;
                b0 = (DiHv - DoLv) / 2;
                bhv = (DoHv - DiHv) / 2;
                blv = (DoLv - DiLv) / 2;
            }
            else
            {
                Lmt = Double.Parse(textLmt.Text);
            }





            double mmf;

            if (comboGroup.SelectedIndex == 0)
            {

                xHv = (2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow((NHv / 2), 2) * (Lmt / w) * (((bhv + blv) / 6) + b0)) / 100;

                xLv = (2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow((NLv / 2), 2) * (Lmt / w) * (((bhv + blv) / 6) + b0)) / 100; ;
            }
            //  گروه    n2 برای
            else
            {
                XHv_2n = (((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0)) / 100; ;

                XLv_2n = (((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0)) / 100; ;

                mmf = (4.44 * frequency * (Ai / 10000) * fluxDensity * 1000) / (kFactor * kFactor);

                εx = (((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / (n * voltagePerTurn)) * mmf * (Lmt / w) * (((bhv + blv) / 6) + b0)) / 100; ;
            }











            if (rating > 4000)
            {
                DialogResult result = MessageBox.Show("Small transformers power is lower than 4kVA.\n\nDo you want to continue? ", "Power range warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    txt_rating.Focus();
                    txt_rating.SelectAll();
                    return;
                }
            }













            dataGridView3.Rows.Clear();

            dataGridView3.Rows.Add("  pho2", "  ohm_cm", string.Format("  {0:0.00000000}", pho2));
            dataGridView3.Rows.Add("  rating", "  ohm_cm", string.Format("  {0:0.00000000}", rating));
            dataGridView3.Rows.Add("  kFactor", "  ohm_cm", string.Format("  {0:0.00000000}", kFactor));

            dataGridView3.Rows.Add("  voltagePerTurn", "  V", string.Format("  {0:0.0000}", voltagePerTurn));

            dataGridView3.Rows.Add("  Ai", "  cm^2", string.Format("  {0:0.0000}", Ai));

            dataGridView3.Rows.Add("  d", "  cm", string.Format("  {0:0.0000}", d));

            dataGridView3.Rows.Add("  a", "  cm", string.Format("  {0:0.0000}", a));

            dataGridView3.Rows.Add("  D", "  cm", string.Format("  {0:0.0000}", D));

            dataGridView3.Rows.Add("  b", "  cm", string.Format("  {0:0.0000}", b));

            dataGridView3.Rows.Add("  Ww", "  cm", string.Format("  {0:0.0000}", Ww));

            dataGridView3.Rows.Add("  Aw", "  cm^2", string.Format("  {0:0.0000}", Aw));

            dataGridView3.Rows.Add("  Hw", "  cm", string.Format("  {0:0.0000}", Hw));

            dataGridView3.Rows.Add("  Hy", "  cm", string.Format("  {0:0.0000}", Hy));

            dataGridView3.Rows.Add("  Dy", "  cm", string.Format("  {0:0.0000}", Dy));

            dataGridView3.Rows.Add("  H", "  cm", string.Format("  {0:0.0000}", H));

            dataGridView3.Rows.Add("  W", "  cm", string.Format("  {0:0.0000}", W));

            dataGridView3.Rows.Add("  NHv", "", string.Format("  {0:0}", NHv));

            dataGridView3.Rows.Add("  NLv", "", string.Format("  {0:0}", NLv));

            dataGridView3.Rows.Add("  IHv", "  Amper", string.Format("  {0:0.0000}", IHv));

            dataGridView3.Rows.Add("  ILv", "  Amper", string.Format("  {0:0.0000}", ILv));

            dataGridView3.Rows.Add("  aHv", "  mm^2", string.Format("  {0:0.0000}", aHv));

            dataGridView3.Rows.Add("  aLv", "  mm^2", string.Format("  {0:0.0000}", aLv));

            dataGridView3.Rows.Add("  dHv", "  mm", string.Format("  {0:0.0000}", dHv));

            dataGridView3.Rows.Add("  dLv", "  mm", string.Format("  {0:0.0000}", dLv));

            dataGridView3.Rows.Add("  index HV", " ", string.Format("  {0:0}", SWGAWGBWGIndexHv));

            dataGridView3.Rows.Add("  index LV", " ", string.Format("  {0:0}", SWGAWGBWGIndexLv));

            dataGridView3.Rows.Add("  RHv", "  ohm", string.Format("  {0:0.0000}", RHv));

            dataGridView3.Rows.Add("  RLv", "  ohm", string.Format("  {0:0.0000}", RLv));

            dataGridView3.Rows.Add("  xHv", "  ohm", string.Format("  {0:0.0000}", xHv));

            dataGridView3.Rows.Add("  XLv", "  ohm", string.Format("  {0:0.0000}", XLv));

            dataGridView3.Rows.Add("  XHv_2n", "  ohm", string.Format("  {0:0.0000}", XHv_2n));

            dataGridView3.Rows.Add("  εx", "  ", string.Format("  {0:0.0000}", εx));






            labelH.Text = "= " + Convert.ToString(string.Format("{0:0}", H));

            labelHV.Text = "= " + Convert.ToString(string.Format("{0:0.00}", NHv));

            labelHw.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Hw));

            labelHy.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Hy));

            labelLv.Text = "= " + Convert.ToString(string.Format("{0:0.00}", NLv));

            labelW.Text = "= " + Convert.ToString(string.Format("{0:0.00}", W));

            labelWw.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Ww));

            label2D.Text = "= " + Convert.ToString(string.Format("{0:0.00}", (D * 2)));

            labelDy.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Dy));






        }

        private void combo_Thicknessofsteel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Thicknessofsteel.SelectedIndex == 0)
            {
                combo_insulation.Items.Remove("Heat resistance coating");
                combo_insulation.Items.Remove("Single layer varnish+Heat resistance coating");
            }
            else if (combo_Thicknessofsteel.SelectedIndex != 0 && !combo_insulation.Items.Contains("Heat resistance coating"))
            {
                combo_insulation.Items.Add("Heat resistance coating");
                combo_insulation.Items.Add("Single layer varnish+Heat resistance coating");

            }
        }


        private void combo_insulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Thicknessofsteel.SelectedIndex == 0)
            {
                if (combo_insulation.SelectedIndex == 0)
                {
                    txt_ks.Text = "0.95";
                }
                else if (combo_insulation.SelectedIndex == 1)
                {
                    txt_ks.Text = "0.93";
                }
                else
                {
                    txt_ks.Text = "0.91";
                }
            }
            else
            {
                if (combo_insulation.SelectedIndex == 0)
                {
                    txt_ks.Text = "0.93";
                }
                else if (combo_insulation.SelectedIndex == 1)
                {
                    txt_ks.Text = "0.91";
                }
                else if (combo_insulation.SelectedIndex == 2)
                {
                    txt_ks.Text = "0.8";
                }
                else if (combo_insulation.SelectedIndex == 3)
                {
                    txt_ks.Text = "0.95";
                }
                else if (combo_insulation.SelectedIndex == 4)
                {
                    txt_ks.Text = "0.93";
                }
            }


        }

      





        












        private double getDFromFile(string filePath, double value, bool highVol)
        {
            var first = new List<double>();
            var second = new List<double>();

            using (var streamReader = new StreamReader(filePath))
            {

                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    first.Add(Double.Parse(arr[0]));
                    second.Add(Double.Parse(arr[1]));
                }
            }
            double res = second.Aggregate((x, y) => Math.Abs(x - value) < Math.Abs(y - value) ? x : y);
            if (highVol)
            {
                SWGAWGBWGIndexHv = (int)first[second.IndexOf(res)];
            }
            else
            {
                SWGAWGBWGIndexLv = (int)first[second.IndexOf(res)];
            }

            return res;
        }





        private void getvalues()
        {



            rating = Double.Parse(txt_rating.Text);
            highVoltage = Double.Parse(txt_HighVoltage.Text);

            lowVoltage = Double.Parse(txt_LowVoltage.Text);

            frequency = Double.Parse(txt_Frequency.Text);

            fluxDensity = Double.Parse(txt_Fluxdensity.Text);

            

            temperatureRise = Double.Parse(txt_tm.Text);

            ambTemperature = Double.Parse(txt_tr.Text);

            Wi = Double.Parse(txt_Wi.Text);





            



           

           
            ks = Double.Parse(txt_ks.Text);


            if (combo_Kw.SelectedIndex == 0)
            {
                kw = Double.Parse(txt_KwValue.Text);
            }







            DiHv = Double.Parse(txt_diHv.Text);

            DoHv = Double.Parse(txt_doHv.Text);

            DiLv = Double.Parse(txt_diLv.Text);

            DoLv = Double.Parse(txt_doLv.Text);

            b0 = Double.Parse(txt_b0.Text);

            bhv = Double.Parse(txt_b1.Text);

            blv = Double.Parse(txt_b2.Text);



            w = Double.Parse(textw.Text);

            n = Double.Parse(textnvalue.Text);

            Lmt = Double.Parse(textLmt.Text);









        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void SmallTrans_Load(object sender, EventArgs e)
        {
            creteSWGInsulations();
            cretwAWGInsulation();
            
            combo_Kw.SelectedIndex = 0;
            
            combo_structure.SelectedIndex = 0;

            combo_Leakageresistancewinding.SelectedIndex = 0;
            comboGroup.SelectedIndex = 0;
            combo_conductor.SelectedIndex = 0;
            
            
            combo_Steel.SelectedIndex = 0;
            combo_Thicknessofsteel.SelectedIndex = 0;
            combo_insulation.SelectedIndex = 0;
            wireGauge.SelectedIndex = 0;
        }

        

        private void combo_Kw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Kw.SelectedIndex != 0)
            {
                txt_KwValue.Enabled = false;
            }
            else
            {
                txt_KwValue.Enabled = true;
            }
        }

        private void combo_Steel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combo_Steel.SelectedIndex == 7)
            {
                if (highVoltage > 0 && highVoltage < 132)
                {
                    txt_Fluxdensity.Text = "1.55";
                }
                else if (highVoltage >= 132 && highVoltage < 275)
                {
                    txt_Fluxdensity.Text = "1.6";
                }
                else if (highVoltage >= 275 && highVoltage < 400)
                {
                    txt_Fluxdensity.Text = "1.7";
                }
                else if (highVoltage >= 400)
                {
                    txt_Fluxdensity.Text = "1.75";
                }
                else
                {
                    txt_Fluxdensity.Text = "1.7";
                }
            }
            else if (combo_Steel.SelectedIndex != 0)
            {
                txt_Fluxdensity.Text = "1.3";
            }





            if (combo_Steel.SelectedIndex == 0)
            {
                if (txt_Frequency.Text == "50")
                {

                    txt_Wi.Text = "2.53";
                }

                else
                {

                    txt_Wi.Text = "3.2";
                }

            }
            else if (combo_Steel.SelectedIndex == 1)
            {
                if (txt_Frequency.Text == "50")
                {

                    txt_Wi.Text = "2.75";
                }
                else
                {

                    txt_Wi.Text = "3.48";
                }

            }
            else if (combo_Steel.SelectedIndex == 2)
            {
                if (txt_Frequency.Text == "50")
                {

                    txt_Wi.Text = "2.93";
                }
                else
                {

                    txt_Wi.Text = "3.7";
                }

            }
            else if (combo_Steel.SelectedIndex == 3)
            {
                if (txt_Frequency.Text == "50")
                {

                    txt_Wi.Text = "3.13";
                }
                else
                {

                    txt_Wi.Text = "3.97";
                }

            }
            else if (combo_Steel.SelectedIndex == 4)
            {
                if (txt_Frequency.Text == "50")
                {

                    txt_Wi.Text = "3.3";
                }
                else
                {

                    txt_Wi.Text = "4.19";
                }

            }

            else
            {
                if (combo_Steel.SelectedIndex == 5)
                {

                    txt_Wi.Text = "1.475";
                }
                else
                {

                    txt_Wi.Text = "1.6";
                }

            }









            if (combo_Steel.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;


            }

            else if (combo_Steel.SelectedIndex == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (combo_Steel.SelectedIndex == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;


            }
            else if (combo_Steel.SelectedIndex == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;


            }
            else if (combo_Steel.SelectedIndex == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;


            }
            else if (combo_Steel.SelectedIndex == 6)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;


            }
            else if (combo_Steel.SelectedIndex == 7)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
            }










        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_diHv.Enabled = false;
            txt_doHv.Enabled = false;
            txt_diLv.Enabled = false;
            txt_diLv.Enabled = false;
            txt_b0.Enabled = false;
            txt_b1.Enabled = false;
            txt_b2.Enabled = false;
            textLmt.Enabled = false;

            textw.Enabled = false;
            comboGroup.Enabled = false;
            textnvalue.Enabled = false;
            label41.Enabled = false;
            label61.Enabled = false;
            label60.Enabled = false;
            label43.Enabled = false;
            label49.Enabled = false;
            label45.Enabled = false;
            label46.Enabled = false;
            label47.Enabled = false;
            
            label51.Enabled = false;
            label52.Enabled = false;
            label53.Enabled = false;
            
            label44.Enabled = false;
            combo_Leakageresistancewinding.Enabled = false;
            


            if (checkBox1.Checked)
            {
                txt_diHv.Enabled = true;
                txt_doHv.Enabled = true;
                txt_diLv.Enabled = true;
                txt_doLv.Enabled = true;
                label41.Enabled = true;
                label61.Enabled = true;
                label60.Enabled = true;
                label43.Enabled = true;

                combo_Leakageresistancewinding.Enabled = true;
                label44.Enabled = true;






            }
            else
            {

                txt_diHv.Enabled = false;
                txt_doHv.Enabled = false;
                txt_diLv.Enabled = false;
                txt_doLv.Enabled = false;
                label41.Enabled = false;
                label61.Enabled = false;
                label60.Enabled = false;
                label43.Enabled = false;

                combo_Leakageresistancewinding.Enabled = true;
                label44.Enabled = true;
                


                txt_b0.Enabled = true;
                txt_b1.Enabled = true;
                txt_b2.Enabled = true;
                textLmt.Enabled = true;
                label49.Enabled = true;
                label45.Enabled = true;
                label46.Enabled = true;
                label47.Enabled = true;



                txt_diHv.Enabled = true;
                txt_doHv.Enabled = true;
                txt_diLv.Enabled = true;
                txt_doLv.Enabled = true;
                label41.Enabled = true;
                label61.Enabled = true;
                label60.Enabled = true;
                label43.Enabled = true;

            }
        }

        private void combo_structure_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            labelHy.Visible = true;
            labelHw.Visible = true;
            labelW.Visible = true;
            labelWw.Visible = true;
            label2D.Visible = true;
            labelDy.Visible = true;
            labelHV.Visible = true;
            labelLv.Visible = true;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);

                        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                        doc.Open();

                        PdfContentByte pdfContent = pdfWriter.DirectContent;

                        iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

                        //customized border sizes
                        rectangle.Left += doc.LeftMargin - 5;

                        rectangle.Right -= doc.RightMargin - 5;

                        rectangle.Top -= doc.TopMargin - 5;

                        rectangle.Bottom += doc.BottomMargin - 5;

                        pdfContent.SetColorStroke(BaseColor.WHITE);//setting the color of the border to white

                        pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);

                        pdfContent.Stroke();

                        using (Bitmap bmp = new Bitmap(tabPage1.Size.Width, tabPage1.Size.Height))
                        {

                            tabPage1.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, tabPage1.Size.Width, tabPage1.Size.Height));

                            bmp.Save(@"Resources\report.jpg", ImageFormat.Png);

                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"Resources\report.jpg");

                            doc.Add(img);
                        }
                        //setting font type, font size and font color
                        iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 25, BaseColor.LIGHT_GRAY);

                        Paragraph p = new Paragraph();

                        p.Alignment = Element.ALIGN_CENTER;//adjust the alignment of the heading

                        p.Add(new Chunk("Report", headerFont));//adding a heading to the PDF

                        doc.Add(p);//adding component to the document

                        Paragraph p2 = new Paragraph();

                        p2.Add(new Chunk("                      ", headerFont));//adding a heading to the PDF

                        doc.Add(p2);//adding component to the document

                        iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.LIGHT_GRAY);

                        //creating pdf table
                        PdfPTable table = new PdfPTable(dataGridView3.Columns.Count);

                        for (int j = 0; j < dataGridView3.Columns.Count; j++)

                        {
                            PdfPCell cell = new PdfPCell(); //create object from the pdfpcell

                            cell.BackgroundColor = BaseColor.WHITE;//set color of cells

                            cell.AddElement(new Chunk(dataGridView3.Columns[j].HeaderText.ToUpper(), font));

                            table.AddCell(cell);
                        }

                        //adding rows from gridview to table
                        for (int i = 0; i < dataGridView3.Rows.Count; i++)
                        {
                            table.WidthPercentage = 100;//set width of the table

                            for (int j = 0; j < dataGridView3.Columns.Count; j++)
                            {
                                if (dataGridView3[j, i].Value != null)

                                    table.AddCell(new Phrase(dataGridView3[j, i].Value.ToString()));
                            }
                        }
                        //adding table to document
                        doc.Add(table);


                        doc.Close();
                        MessageBox.Show("You have successfully exported the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void maskvoltreg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskEff_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txt_delta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            

        }

        private void txt_ratingvalue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            





        }
    }
}
