using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace trans_1
{
    public partial class SinglePhaseTransformer : Form
    {
        private double maxLmtPerLi;
        private double minLmtPerLi;

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

        private int SWGAWGBWGIndexHv = -1;
        private int SWGAWGBWGIndexLv = -1;

        private List<double> swgInsulations = new List<double>();
        private List<double> awgInsulations = new List<double>();


        private int SWGAWGBWGIndex = -1;


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








        public SinglePhaseTransformer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getvalues();



            //kw

            //  S < 10

            if (combo_Kw.SelectedIndex == 1)
            {
                if (rating <= 10)
                {
                    kw = 8 / (30 + highVoltage);
                }
                else if (rating <= 50 && rating > 10)
                {
                    //  10 < S < 50
                    kw = 9 / (30 + highVoltage);
                }
                else if (rating <= 200 && rating > 50)
                {
                    //  50 < S < 200
                    kw = 10 / (30 + highVoltage);
                }
                else if (rating <= 500 && rating > 200)
                {
                    //  200 < S < 500
                    kw = 11 / (30 + highVoltage);
                }
                else if (rating <= 1000 && rating > 500)
                {
                    //  500 < S < 1000
                    kw = 12 / (30 + highVoltage);
                }
                else if (rating <= 2000 && rating > 1000)
                {
                    //  1000 < S < 2000
                    kw = 13 / (30 + highVoltage);
                }
                else if (rating <= 5000 && rating > 2000)
                {
                    //  2000 < S < 5000
                    kw = 14 / (30 + highVoltage);
                }

                else if (rating <= 10000 && rating > 5000)
                {
                    //  5000 < S < 10000
                    kw = 15 / (30 + highVoltage);
                }
                else if (rating <= 20000 && rating > 10000)
                {
                    //  10000 < S < 2000
                    kw = 16 / (30 + highVoltage);
                }
                else if (rating > 20000)
                {
                    //  10000 < S < 2000
                    kw = 20 / (30 + highVoltage);
                }


            }










;






            // Aw cm^2
            Aw = (rating * Math.Pow(10, 5)) / (2.22 * fluxDensity * frequency * delta * kw * Ai);



            //Acu
            
            Acu = Aw * kw;


            //d
            d = Math.Sqrt(Ai / kc);

            double Agi = Ai / sf;


            a = 0;
            b = 0;
            D = 0;
            Ww = 0;
            Hw = 0;
            Dy = 0;
            Hy = 0;
            H = 0;
            W = 0;
            // هسته مربعی
            if (comboCrossSection.SelectedIndex == 0)
            {
                 a = 0.71 * d;
                 b = a;
            }
            
            // درترانس های ستونی کوچک هسته مستطیلی ساده به کار میبرند با افزایش اندازه مربعی بکار میبرند

            // هسته صلیبی

            else if (comboCrossSection.SelectedIndex == 1)
            {
                a = 0.85 * d;
                b = 0.53 * d;
            }
            
            
            
            // هسته سه دندانه
            else if (comboCrossSection.SelectedIndex == 2)
            {

                a = 0.9 * d;
                if (combo_structure.SelectedIndex == 0)
                {
                    b = a / 1.5;
                }
                else
                {
                    b = 2 * a * 2.5;
                }
            }

            //b      در اینحا و 4 دندانه ای این مقدار  از نوع ستونی و زرهی بدست می آیند

            // هسته چهار دندانه
            else if (comboCrossSection.SelectedIndex == 3)
            {
                a = 0.91 * d;
                if (combo_structure.SelectedIndex == 0)
                {
                    b = a / 1.5;
                }
                else
                {
                    b = 2 * a * 2.5;
                }
            }


            // D ستونی
            if (combo_structure.SelectedIndex == 0)
            {
                 D = DPera * a;

                 Ww = D - d;

                 Hw = Aw / Ww;

                 Dy = a;

                 Hy = ((Ww * Ai) / (a * sf));

                 H = Hw + (2 * Hy);

                 W = D + a;
            }

            // D زرهی
            else
            {
                D = DPera * a;

                Ww = D - d;

                Hw = Aw / Ww;

                Dy = b;

                Hy = a;

                H = Hw + (2 * Hy);

                W = 2 * Ww;

            }



            // طراحی سیم پیچ ها

            NHv = highVoltage / voltagePerTurn;

            IHv = (rating * 1000) / highVoltage;
            //mm^2
            aHv = IHv / delta;
            //mm
            dHv = Math.Sqrt((4 * aHv) / Math.PI);

            
            double fileD;
            if (wireGauge.SelectedIndex == 0)
            {
                fileD = getDFromFile(@"Resources\\SWG.txt", dHv , true);
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


            double LmtHv = (Math.PI * (DiHv + DiLv)) / 2;

            RHv = (pho2 * NHv * LmtHv) / aHv;


            
            



            // طراحی سیم پیچ ها

            NLv = lowVoltage / voltagePerTurn;

            ILv = (rating * 1000) / highVoltage;

            aLv = ILv / delta;

            dLv = Math.Sqrt((4 * aLv) / Math.PI);


                       
            if (wireGauge.SelectedIndex == 0)
            {
                fileD = getDFromFile(@"Resources\\SWG.txt", dLv , false);
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


            double LmtLv = Math.PI * ((DiHv + DiLv) / 2);

            RLv = (pho2 * NLv * LmtLv) / aHv;



            xHv = 0;
            xLv = 0;
            XHv = 0;
            XLv = 0;
            double mmf = 0;
            εx = 0;
            // Concentric  برای ترانس ستونی
            if (combo_Leakageresistancewinding.SelectedIndex == 0)
            {
                 xHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2) * (Lmt / hc) * ((bhv / 3) + (b0 / 2));

                 xLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2) * (Lmt / hc) * ((bhv / 3) + (b0 / 2));

                 XHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2) * (Lmt / hc) * (((bhv + blv) / 3) + b0);

                 XLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2) * (Lmt / hc) * (((bhv + blv) / 3) + b0);

                 mmf = (4.44 * frequency * Ai * fluxDensity * 1000) / (kFactor * kFactor);

                 εx = ((2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / voltagePerTurn) * mmf * (Lmt / hc) * (((bhv + blv) / 3) + b0);
            }
            else
            {
                // Sandwitch  برای ترانس صدفی

                // برای یک گروه
                if (comboGroup.SelectedIndex == 0)
                {

                    xHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow((NHv / 2), 2) * (Lmt / w) * (((bhv + blv) / 6) + b0);

                    xLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow((NLv / 2), 2) * (Lmt / w) * (((bhv + blv) / 6) + b0);
                }
                //  گروه    n2 برای
                else
                {
                    XHv_2n = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0);

                    XLv_2n = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0);

                    mmf = (4.44 * frequency * Ai * fluxDensity * 1000) / (kFactor * kFactor);

                    εx = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / (n * voltagePerTurn)) * mmf * (Lmt / w) * (((bhv + blv) / 6) + b0);
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
            if (rdbRaiting.Checked)
            {
                rating = Double.Parse(txt_ratingvalue.Text);
                voltagePerTurn = kFactor * Math.Sqrt(rating);
                txt_voltageperturnvalue.Text = Convert.ToString(voltagePerTurn);
            }
            else if (rdbVoltagePerTurn.Checked)
            {
                voltagePerTurn = Double.Parse(txt_voltageperturnvalue.Text);
                rating = Math.Pow((voltagePerTurn / kFactor), 2);
                txt_ratingvalue.Text = Convert.ToString(rating);
            }
            

           

            highVoltage = Double.Parse(txt_HighVoltage.Text);

            lowVoltage = Double.Parse(txt_LowVoltage.Text);

            frequency = Double.Parse(txt_Frequency.Text);

            fluxDensity = Double.Parse(txt_Fluxdensity.Text);

            delta = Double.Parse(txt_delta.Text);

            temperatureRise = Double.Parse(txt_tm.Text);

            ambTemperature = Double.Parse(txt_tr.Text);

            Wi = Double.Parse(txt_Wi.Text);



            if (combo_Ai.SelectedIndex != 5)
            {
                GiPerGcu = Double.Parse(txt_Gi_Gcu.Text);
            }

            lmtPerLi = Double.Parse(txt_LmtLi.Text);

            gcuPergi = Double.Parse(txt_gcugi.Text);

            CiPerCcu = Double.Parse(txt_CiCu.Text);

            x = Double.Parse(txt_Load.Text);

            DPera = Double.Parse(txt_Da.Text);

            AcuPerAi = Double.Parse(txt_AcuAi.Text);

            ks = Double.Parse(txt_ks.Text);

            kc = Double.Parse(txt_Kc.Text);
            if (combo_Kw.SelectedIndex == 0)
            {
                kw = Double.Parse(txt_KwValue.Text);
            }

           

            kFactor = Double.Parse(txt_kFactor.Text);

            sf = Double.Parse(txt_Stackingfactor.Text);

            DiHv = Double.Parse(txt_diHv.Text);

            DoHv = Double.Parse(txt_doLv.Text);

            DiLv = Double.Parse(txt_diLv.Text);

            DoLv = Double.Parse(txt_doLv.Text);

            b0 = Double.Parse(txt_b0.Text);

            bhv = Double.Parse(txt_b1.Text);

            blv = Double.Parse(txt_b2.Text);

            hc = Double.Parse(texthc.Text);

            w = Double.Parse(textw.Text);

            n = Double.Parse(textnvalue.Text);

            Lmt = Double.Parse(textLmt.Text);

            y = Double.Parse(txt_y.Text);

            SLL = Double.Parse(txtSLL.Text);

            

            // cm^2
            if (combo_Ai.SelectedIndex == 0)
            {
                //user
                Ai = Double.Parse(combo_Ai.Text);
            }
            else if (combo_Ai.SelectedIndex == 1)
            {
                //Et
                Ai = (voltagePerTurn * Math.Pow(10, 4)) / (4.44 * frequency * fluxDensity);
            }
            else if (combo_Ai.SelectedIndex == 2)
            {
                //cost
                Ai = Math.Sqrt((1000 * rating * lmtPerLi * gcuPergi * GiPerGcu) / (2.22 * frequency * fluxDensity * delta)) * 10000;
            } else if (combo_Ai.SelectedIndex == 3)
            {

                // efficiency
                double pho = 2.1e-6;
                double RT1 = 234.5 + temperatureRise;
                double RT2 = 234.5 + (temperatureRise + ambTemperature);
                pho2 = pho / (RT1 / RT2);

                WiT = (1 + (y / 100)) * Wi;

                // wat/kg
                Wcu = (Math.Pow((delta * Math.Pow(10, -6)), 2) * pho2) / 890000;

                WcuT = (1 + (SLL / 100)) * Wcu;

                GiPerGcu = Math.Pow((x / 100), 2) * (WcuT / WiT);

                Ai = Math.Sqrt((1000 * rating * lmtPerLi * gcuPergi * GiPerGcu) / (2.22 * frequency * fluxDensity * delta)) * 10000;
            } else if (combo_Ai.SelectedIndex == 4)
            {
                //weight
                
                
                Ai = Math.Sqrt((1000 * rating * lmtPerLi * gcuPergi * GiPerGcu) / (2.22 * frequency * fluxDensity * delta)) * 10000;
            } else if (combo_Ai.SelectedIndex == 5)
            {
                //volume
                GiPerGcu = 1 / gcuPergi;
                Ai = Math.Sqrt((1000 * rating * lmtPerLi * GiPerGcu) / (2.22 * frequency * fluxDensity * delta)) * 10000;
            }



            
        }

        private void rdbRaiting_CheckedChanged(object sender, EventArgs e)
        {
            txt_ratingvalue.Enabled = true;
            txt_voltageperturnvalue.Enabled = false;
        }

        private void rdbVoltagePerTurn_CheckedChanged(object sender, EventArgs e)
        {
            txt_ratingvalue.Enabled = false;
            txt_voltageperturnvalue.Enabled = true;
        }

        private void SinglePhaseTransformer_Load(object sender, EventArgs e)
        {
            creteSWGInsulations();
            cretwAWGInsulation();
            combo_Ai.SelectedIndex = 0;
            combo_Kw.SelectedIndex = 0;
            comboCrossSection.SelectedIndex = 0;
            combo_structure.SelectedIndex = 0;

            combo_Leakageresistancewinding.SelectedIndex = 0;
            comboGroup.SelectedIndex = 0;
            combo_conductor.SelectedIndex = 0;
            combo_application.SelectedIndex = 0;
            combo_Currentdensity.SelectedIndex = 0;
            combo_Steel.SelectedIndex = 0;
            combo_Thicknessofsteel.SelectedIndex = 0;
            combo_insulation.SelectedIndex = 0;
        }

        private void combo_Ai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Ai.SelectedIndex != 0)
            {
                txt_AiValue.Enabled = false;
            }
            else
            {
                txt_AiValue.Enabled = true;
            }

            if (combo_Ai.SelectedIndex == 5)
            {
                txt_Gi_Gcu.Enabled = false;
            }
            else
            {
                txt_Gi_Gcu.Enabled = true;
            }

            if(combo_Ai.SelectedIndex == 4)
            {
                txt_Gi_Gcu.Text = "1";
            }
            else
            {
                txt_Gi_Gcu.Text = "";
            }


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

        private void comboCrossSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCrossSection.SelectedIndex == 0)
            {
                txt_Kc.Text = "0.45";

            } else if (comboCrossSection.SelectedIndex == 1)
            {
                txt_Kc.Text = "0.56";
            }
            else if (comboCrossSection.SelectedIndex == 2)
            {
                txt_Kc.Text = "0.60";
            }
            else if (comboCrossSection.SelectedIndex == 3)
            {
                txt_Kc.Text = "0.62";
            }
        }

        private void combo_structure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_structure.SelectedIndex == 0)
            {
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;

                labelH.Visible = false;
                labelHy.Visible = false;
                labelHw.Visible = false;
                labelW.Visible = false;
                labelWw.Visible = false;
                label2D.Visible = false;
                labelDy.Visible = false;
                labelHV.Visible = false;
                labelLv.Visible = false;


                combo_Leakageresistancewinding.SelectedIndex = 0;
                txt_kFactor.Text = "0.8";
                maxLmtPerLi = 0.55;
                minLmtPerLi = 0.3;
                txt_LmtLi.Text = "0.4";
            }
            else
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

                combo_Leakageresistancewinding.SelectedIndex =1;
                txt_kFactor.Text = "1";
                maxLmtPerLi = 2;
                minLmtPerLi = 1.2;
                txt_LmtLi.Text = "1.5";
            }



            



        }

        private void combo_Leakageresistancewinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Leakageresistancewinding.SelectedIndex == 0)
            {
                combo_structure.SelectedIndex = 0;

            }
            else
            {
                combo_structure.SelectedIndex = 1;
            }
        }

        private void combo_conductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_conductor.SelectedIndex == 0)
            {
                txt_CiCu.Text = "0.13";
            }
            else
            {
                txt_CiCu.Text = "0.2";
            }
        }

        private void combo_application_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_application.SelectedIndex == 1)
            {
                combo_Currentdensity.Items.RemoveAt(2);
                combo_Currentdensity.Items.RemoveAt(2);
                combo_Currentdensity.Items.RemoveAt(2);
            }
            if(combo_application.SelectedIndex == 0 && !combo_Currentdensity.Items.Contains("AF"))
            {
                combo_Currentdensity.Items.Add("AF");
                combo_Currentdensity.Items.Add("OF");
                combo_Currentdensity.Items.Add("WF");
                
            }
        }



        private void txt_kFactor_Validated(object sender, EventArgs e)
        {
            if (combo_structure.SelectedIndex == 0)
            {
                try
                {
                    if (Double.Parse(txt_kFactor.Text) > 0.85)
                    {
                        txt_kFactor.Text = "0.85";
                    }
                    else if (Double.Parse(txt_kFactor.Text) < 0.75)
                    {
                        txt_kFactor.Text = "0.75";
                    }
                }
                catch (Exception)
                {

                }
            }
        }


        private void txt_kFactor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LmtLi_Validated(object sender, EventArgs e)
        {
            if (Double.Parse(txt_LmtLi.Text) > maxLmtPerLi)
            {
                MessageBox.Show("the value is grater than " + $"{maxLmtPerLi}");
                txt_LmtLi.Text = Convert.ToString(maxLmtPerLi);
            }
            if (Double.Parse(txt_LmtLi.Text) < minLmtPerLi)
            {
                MessageBox.Show("the value is less than " + $"{minLmtPerLi}");
                txt_LmtLi.Text = Convert.ToString(minLmtPerLi);
            }
        }

        private void combo_Currentdensity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Currentdensity.SelectedIndex == 1 || combo_Currentdensity.SelectedIndex == 2)
            {
                txt_delta.Text = "2.5";
            } else if (combo_Currentdensity.SelectedIndex == 3)
            {
                txt_delta.Text = "3.4";
            } else if (combo_Currentdensity.SelectedIndex == 4)
            {
                txt_delta.Text = "6";
            }
        }

        private void combo_Steel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Steel.SelectedIndex == 7 && combo_application.SelectedIndex == 0)
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
            } else if (combo_Steel.SelectedIndex != 0 && combo_Steel.SelectedIndex != 7)
            {
                if (combo_application.SelectedIndex == 0)
                {
                    txt_Fluxdensity.Text = "1.35";
                }
                else
                {
                    txt_Fluxdensity.Text = "1.3";
                }
            }



            if(combo_Steel.SelectedIndex == 1)
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

        private void txt_Fluxdensity_Validated(object sender, EventArgs e)
        {
            if (combo_Steel.SelectedIndex != 0 && combo_Steel.SelectedIndex != 7)
            {
                if (combo_application.SelectedIndex == 0)
                {
                    if (Double.Parse(txt_Fluxdensity.Text) < 1.25)
                    {
                        MessageBox.Show("Invalid value");
                        txt_Fluxdensity.Text = "1.25";
                    }
                }
                else
                {
                    txt_Fluxdensity.Text = "1.3";
                }
            }
        }

        private void combo_Thicknessofsteel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Thicknessofsteel.SelectedIndex == 0)
            {
                combo_insulation.Items.Remove("Heat resistance coating");
                combo_insulation.Items.Remove("Single layer varnish+Heat resistance coating");
            }
            else if(combo_Thicknessofsteel.SelectedIndex != 0 && !combo_insulation.Items.Contains("Heat resistance coating"))
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
                else if (combo_insulation.SelectedIndex ==2)
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





            if(combo_structure.SelectedIndex == 0)
            {
                lblPicH.Text = "= " + Convert.ToString(string.Format("{0:0.00}", H));

                lblPicHw.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Hw));

                lblPicHy.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Hy));

                lblPicW.Text = "= " + Convert.ToString(string.Format("{0:0.00}", W));

                lblPicWw.Text = "= " + Convert.ToString(string.Format("{0:0.00}", Ww));

                lblPicD.Text = "= " + Convert.ToString(string.Format("{0:0.00}", D));

                lblPicDy.Text = "= " + Convert.ToString(string.Format("{0:0}", Dy));
            }
            else
            {
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
            



            










            dataGridView3.Rows.Clear();

            dataGridView3.Rows.Add("  pho2", "  ohm_cm", string.Format("  {0:0.00000000}", pho2));

            dataGridView3.Rows.Add("  H", "  cm", string.Format("  {0:0.0000}", H));

            dataGridView3.Rows.Add("  W", "  cm", string.Format("  {0:0.0000}", W));

            dataGridView3.Rows.Add("  Hw", "  cm", string.Format("  {0:0.0000}", Hw));

            dataGridView3.Rows.Add("  Ww", "  cm", string.Format("  {0:0.0000}", Ww));

            dataGridView3.Rows.Add("  Hy", "  cm", string.Format("  {0:0.0000}", Hy));

            dataGridView3.Rows.Add("  Dy", "  cm", string.Format("  {0:0.0000}", Dy));

            dataGridView3.Rows.Add("  D", "  cm", string.Format("  {0:0.0000}", D));

            dataGridView3.Rows.Add("  Ai", "  cm", string.Format("  {0:0.0000}", Ai));

            dataGridView3.Rows.Add("  Aw", "  cm", string.Format("  {0:0.0000}", Aw));

            dataGridView3.Rows.Add("  a", "", string.Format("  {0:0}", a));

            dataGridView3.Rows.Add("  b", "", string.Format("  {0:0}", b));

            dataGridView3.Rows.Add("  d", "", string.Format("  {0:0}", d));

            dataGridView3.Rows.Add("  diLv", "", string.Format("  {0:0}", diLv));

            dataGridView3.Rows.Add("  diHv", "", string.Format("  {0:0.0000}", diHv));

            dataGridView3.Rows.Add("  index HV", " ", string.Format("  {0:0}", SWGAWGBWGIndexHv));

            dataGridView3.Rows.Add("  index LV", " ", string.Format("  {0:0}", SWGAWGBWGIndexLv));

            dataGridView3.Rows.Add("  ILv", "  cm^2", string.Format("  {0:0.0000}", ILv));

            dataGridView3.Rows.Add("  IHv", "  cm", string.Format("  {0:0.0000}", IHv));

            dataGridView3.Rows.Add("  RHv", "  ohm", string.Format("  {0:0.0000}", RHv));

            dataGridView3.Rows.Add("  RLv", "  Amper", string.Format("  {0:0.0000}", RLv));

            dataGridView3.Rows.Add("  aHv", "  Amper", string.Format("  {0:0.0000}", aHv));

            dataGridView3.Rows.Add("  aLv", "  Amper", string.Format("  {0:0.0000}", aLv));

            dataGridView3.Rows.Add("  xHv", "  Amper", string.Format("  {0:0.0000}", xHv));

            dataGridView3.Rows.Add("  xLv", "  Amper", string.Format("  {0:0.0000}", xLv));

            dataGridView3.Rows.Add("  XLv", "  Amper", string.Format("  {0:0.0000}", XLv));

            dataGridView3.Rows.Add("  XLv", "  Amper", string.Format("  {0:0.0000}", XLv));

            dataGridView3.Rows.Add("  εx", "  Amper", string.Format("  {0:0.0000}", εx));
            
            
            














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

        
    }
    }
