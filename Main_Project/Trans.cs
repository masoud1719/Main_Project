using System;
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

        

        public SinglePhaseTransformer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getvalues();






            //kw

            //  S < 10

            if (combo_Kw.SelectedIndex == 2)
            {
                if (rating < 10)
                {
                    kw = 8 / (30 + highVoltage);
                }
                else if (rating < 50 && rating > 10)
                {
                    //  10 < S < 50
                    kw = 9 / (30 + highVoltage);
                }
                else if (rating < 200 && rating > 50)
                {
                    //  50 < S < 200
                    kw = 10 / (30 + highVoltage);
                }
                else if (rating < 500 && rating > 200)
                {
                    //  200 < S < 500
                    kw = 11 / (30 + highVoltage);
                }
                else if (rating < 1000 && rating > 500)
                {
                    //  500 < S < 1000
                    kw = 12 / (30 + highVoltage);
                }
                else if (rating < 2000 && rating > 1000)
                {
                    //  1000 < S < 2000
                    kw = 13 / (30 + highVoltage);
                }
                else if (rating < 5000 && rating > 2000)
                {
                    //  2000 < S < 5000
                    kw = 14 / (30 + highVoltage);
                }

                else if (rating < 10000 && rating > 5000)
                {
                    //  5000 < S < 10000
                    kw = 15 / (30 + highVoltage);
                }
                else if (rating < 20000 && rating > 10000)
                {
                    //  10000 < S < 2000
                    kw = 16 / (30 + highVoltage);
                }
            } else if (combo_Kw.SelectedIndex == 1)
            {

            }
            









;






            // Aw cm^2
            double Aw = (rating * Math.Pow(10, 5)) / (2.22 * fluxDensity * frequency * delta * kw * Ai);



            //Acu
            double Acu = Aw * kw;


            //d
            double d = Math.Sqrt(Ai / kc);

            double Agi = Ai / sf;


            double a = 0;
            double b = 0;
            double D = 0;
            double Ww = 0;
            double Hw = 0;
            double Dy = 0;
            double Hy = 0;
            double H = 0;
            double W = 0;
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

            double NHv = highVoltage / voltagePerTurn;

            double IHv = (rating * 1000) / highVoltage;

            double aHv = IHv / delta;

            double dHv = Math.Sqrt((4 * aHv) / Math.PI);

            double diHv = dHv;

            double LmtHv = (Math.PI * (DiHv + DiLv)) / 2;

            double RHv = (pho2 * NHv * LmtHv) / aHv;




            // طراحی سیم پیچ ها

            double NLv = lowVoltage / voltagePerTurn;

            double ILv = (rating * 1000) / highVoltage;

            double aLv = IHv / delta;

            double dLv = Math.Sqrt((4 * aHv) / Math.PI);

            double diLv = dHv;

            double LmtLv = (Math.PI * (DiHv + DiLv)) / 2;

            double RLv = (pho2 * NLv * LmtLv) / aHv;



            double xHv = 0;
            double xLv = 0;
            double XHv = 0;
            double XLv = 0;
            double mmf = 0;
            double εx_Concentric = 0;
            // Concentric  برای ترانس ستونی
            if (combo_Leakageresistancewinding.SelectedIndex == 0)
            {
                 xHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2) * (Lmt / hc) * ((bhv / 3) + (b0 / 2));

                 xLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2) * (Lmt / hc) * ((bhv / 3) + (b0 / 2));

                 XHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2) * (Lmt / hc) * (((bhv + blv) / 3) + b0);

                 XLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2) * (Lmt / hc) * (((bhv + blv) / 3) + b0);

                 mmf = (4.44 * frequency * Ai * fluxDensity * 1000) / (kFactor * kFactor);

                 εx_Concentric = ((2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / voltagePerTurn) * mmf * (Lmt / hc) * (((bhv + blv) / 3) + b0);
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
                    double XHv_2n = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0);

                    double XLv_2n = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0);

                    mmf = (4.44 * frequency * Ai * fluxDensity * 1000) / (kFactor * kFactor);

                    double εx_Sandwitch = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / (n * voltagePerTurn)) * mmf * (Lmt / w) * (((bhv + blv) / 6) + b0);
                }

                
            }


        }

        private void getvalues()
        {
            if (rdbRaiting.Checked)
            {
                rating = Double.Parse(rdbRaiting.Text);
                voltagePerTurn = kFactor / Math.Sqrt(rating);
                txt_voltageperturnvalue.Text = Convert.ToString(voltagePerTurn);
            }
            else if (rdbVoltagePerTurn.Checked)
            {
                voltagePerTurn = Double.Parse(txt_voltageperturnvalue.Text);
                rating = Math.Pow((kFactor / voltagePerTurn), 2);
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

            ks = Double.Parse(txt_Kc.Text);

            kc = Double.Parse(txt_Kc.Text);
            if (combo_Kw.SelectedIndex == 0)
            {
                kw = Double.Parse(combo_Kw.Text);
            }

           

            kFactor = Double.Parse(txt_kFactor.Text);

            sf = Double.Parse(txt_Stackingfactor.Text);

            fluxDensity = Double.Parse(txt_Fluxdensity.Text);

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

            Wcu = Double.Parse(txtWcu.Text);


            if (combo_Ai.SelectedIndex == 0)
            {
                Ai = Double.Parse(combo_Ai.Text);
            }
            else if (combo_Ai.SelectedIndex == 1)
            {
                Ai = (voltagePerTurn * Math.Pow(10, 2)) / (4.44 * frequency * fluxDensity);
            }
            else if (combo_Ai.SelectedIndex == 2)
            {
                Ai = Math.Sqrt(((1000 * rating) / (2.22 * frequency * fluxDensity * delta)) * lmtPerLi * gcuPergi * GiPerGcu);
            } else if (combo_Ai.SelectedIndex == 3)
            {
                double pho = 2.1e-6;
                double RT1 = 234.5 + temperatureRise;
                double RT2 = 234.5 + (temperatureRise + ambTemperature);
                pho2 = pho / (RT1 / RT2);

                WiT = (1 + (y / 100)) * Wi;

                Wcu = (Math.Pow((delta * Math.Pow(10, -6)), 2) * pho2) / 89000;

                WcuT = (1 + (SLL / 100)) * Wcu;

                GiPerGcu = Math.Pow((x / 100), 2) * (WcuT / WiT);

                Ai = Math.Sqrt(((1000 * rating) / (2.22 * frequency * fluxDensity * delta) * lmtPerLi * gcuPergi * GiPerGcu));
            } else if (combo_Ai.SelectedIndex == 4)
            {
                Ai = Math.Sqrt(((1000 * rating) / (2.22 * frequency * fluxDensity * delta) * lmtPerLi * gcuPergi * 1));
            } else if (combo_Ai.SelectedIndex == 5)
            {
                GiPerGcu = 1 / gcuPergi;
                Ai = Math.Sqrt(((1000 * rating) / (2.22 * frequency * fluxDensity * delta) * lmtPerLi * 0.86));
            }



            // you should add the rest of them
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

            if (combo_Ai.SelectedIndex == 5)
            {
                txt_Gi_Gcu.Enabled = false;
            }
            else
            {
                txt_Gi_Gcu.Enabled = true;
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
                combo_Leakageresistancewinding.SelectedIndex = 0;
                txt_kFactor.Text = "0.8";
                maxLmtPerLi = 0.55;
                minLmtPerLi = 0.3;
                txt_LmtLi.Text = "0.4";
            }
            else
            {
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

        private void txt_Kfactor_MaskChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_kFactor_TextChanged(object sender, EventArgs e)
        {
            
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
                catch (Exception exception)
                {

                }
            }
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
            if (combo_Steel.SelectedIndex == 7)
            {
                if (combo_application.SelectedIndex == 0)
                {
                    if (highVoltage > 0 && highVoltage < 132)
                    {
                        txt_Fluxdensity.Text= "1.55";
                    } else if (highVoltage >= 132 && highVoltage < 275)
                    {
                        txt_Fluxdensity.Text = "1.6";
                    }
                    else if (highVoltage >= 275 && highVoltage < 400)
                    {
                        txt_Fluxdensity.Text = "1.7";
                    }
                    else if (highVoltage >= 400 )
                    {
                        txt_Fluxdensity.Text = "1.75";
                    }
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
        }
    }
}