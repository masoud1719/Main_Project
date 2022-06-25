using System;
using System.Windows.Forms;

namespace trans_1
{
    public partial class SinglePhaseTransformer : Form
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

        

        public SinglePhaseTransformer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getvalues();


            // s and Et
             voltagePerTurn = kFactor / Math.Sqrt(rating);

            double raiting = Math.Pow((kFactor / voltagePerTurn), 2);




            // Ai calc

            // user
            double Ai;


            // Et
            Ai = (voltagePerTurn * Math.Pow(10, 2)) / (4.44 * frequency * fluxDensity);


            //cost    Gi/Gcu = Ccu/ Ci
            Ai = Math.Sqrt(((1000 * raiting) / (2.22 * frequency * fluxDensity * delta)) * lmtPerLi * gcuPergi * GiPerGcu);


            //efficiently   

            double pho = 2.1e-6;
            double RT1 = 234.5 + temperatureRise;
            double RT2 = 234.5 + (temperatureRise + ambTemperature);
            pho2 = pho / (RT1 / RT2);

            WiT = (1 + (y / 100)) * Wi;

            Wcu = (Math.Pow((delta * Math.Pow(10, -6)), 2) * pho2) / 89000;

            WcuT = (1 + ( SLL / 100)) * Wcu;

            GiPerGcu = Math.Pow((x / 100), 2) * (WcuT / WiT);
            
            Ai = Math.Sqrt(((1000 * raiting) / (2.22 * frequency * fluxDensity * delta) * lmtPerLi * gcuPergi * GiPerGcu));


            //weight
            GiPerGcu = 1;
            Ai = Math.Sqrt(((1000 * raiting) / (2.22 * frequency * fluxDensity * delta) * lmtPerLi * gcuPergi * 1));


            // volume             cm^2
            GiPerGcu = gcuPergi = 0.86;
            Ai = Math.Sqrt(((1000 * raiting) / (2.22 * frequency * fluxDensity * delta) * lmtPerLi * 0.86));





            //kw

            //  S < 10
            kw = 8 / (30 + highVoltage);

            //  10 < S < 50
            kw = 9 / (30 + highVoltage);

            //  50 < S < 200
            kw = 10 / (30 + highVoltage);

            //  200 < S < 500
            kw = 11 / (30 + highVoltage);

            //  500 < S < 1000
            kw = 12 / (30 + highVoltage);

            //  1000 < S < 2000
            kw = 13 / (30 + highVoltage);

            //  2000 < S < 5000
            kw = 14 / (30 + highVoltage);

            //  5000 < S < 10000
            kw = 15 / (30 + highVoltage);

            //  10000 < S < 2000
            kw = 16 / (30 + highVoltage);






            // Aw cm^2
            double Aw = (raiting * Math.Pow(10, 5)) / (2.22 * fluxDensity * frequency * delta * kw * Ai);



            //Acu
            double Acu = Aw * kw;


            //d
            double d = Math.Sqrt(Ai / kc);

            double Agi = Ai / sf;


            
            // هسته مربعی
            double a = 0.71 * d;
            double b = a;
            // درترانس های ستونی کوچک هسته مستطیلی ساده به کار میبرند با افزایش اندازه مربعی بکار میبرند

            // هسته صلیبی
            a = 0.85 * d;
            b = 0.53 * d;

            
            // هسته سه دندانه
            a = 0.9 * d;
            //b      در اینحا و 4 دندانه ای این مقدار  از نوع ستونی و زرهی بدست می آیند


            // هسته چهار دندانه
            a = 0.91 * d;




            // D ستونی

            double D = DPera * a;

            double Ww = D - d;

            double Hw = Aw / Ww;

            double Dy = a;

            double Hy = ((Ww * Ai) / (a * sf));

            double H = Hw + (2 * Hy);

            double W = D + a;

            b = a / 1.5;


            // D زرهی

            D = DPera * a;

            Ww = D - d;

            Hw = Aw / Ww;

            b = 2 * a * 2.5;

            Dy = b;

            Hy = a;

            H = Hw + (2 * Hy);

            W = 2 * Ww;





            // طراحی سیم پیچ ها

            double NHv = highVoltage / voltagePerTurn;

            double IHv = (raiting * 1000) / highVoltage;

            double aHv = IHv / delta;

            double dHv = Math.Sqrt((4 * aHv) / Math.PI);

            double diHv = dHv;

            double LmtHv = (Math.PI * (DiHv + DiLv)) / 2;

            double RHv = (pho2 * NHv * LmtHv) / aHv;




            // طراحی سیم پیچ ها

            double NLv = lowVoltage / voltagePerTurn;

            double ILv = (raiting * 1000) / highVoltage;

            double aLv = IHv / delta;

            double dLv = Math.Sqrt((4 * aHv) / Math.PI);

            double diLv = dHv;

            double LmtLv = (Math.PI * (DiHv + DiLv)) / 2;

            double RLv = (pho2 * NLv * LmtLv) / aHv;




            // Concentric  برای ترانس ستونی

            double xHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2) * (Lmt / hc) * ((bhv / 3) + (b0 / 2));

            double xLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2) * (Lmt / hc) * ((bhv / 3) + (b0 / 2));

            double XHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2) * (Lmt / hc) * (((bhv + blv) / 3) + b0);

            double XLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2) * (Lmt / hc) * (((bhv + blv) / 3) + b0);

            double mmf = (4.44 * frequency * Ai * fluxDensity * 1000) / (kFactor * kFactor);

            double εx_Concentric = ((2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / voltagePerTurn) * mmf * (Lmt / hc) * (((bhv + blv) / 3) + b0);



            // Sandwitch  برای ترانس صدفی

            // برای یک گروه

            xHv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow((NHv / 2), 2) * (Lmt / w) * (((bhv + blv) / 6) + b0);

            xLv = 2 * Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow((NLv / 2), 2) * (Lmt / w) * (((bhv + blv) / 6) + b0);


            //  گروه    n2 برای

            double XHv_2n = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NHv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0);

            double XLv_2n = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI * Math.Pow(NLv, 2)) / n) * (Lmt / w) * (((bhv + blv) / 6) + b0);

            mmf = (4.44 * frequency * Ai * fluxDensity * 1000) / (kFactor * kFactor);

            double εx_Sandwitch = ((Math.PI * frequency * 4 * Math.Pow(10, -7) * Math.PI) / (n * voltagePerTurn)) * mmf * (Lmt / w) * (((bhv + blv) / 6) + b0);










        }

        private void getvalues()
        {
            rating = Double.Parse(txt_raiting.Text);

            voltagePerTurn = Double.Parse(txt_voltageperturnvalue.Text);

            highVoltage = Double.Parse(txt_HighVoltage.Text);

            lowVoltage = Double.Parse(txt_LowVoltage.Text);

            frequency = Double.Parse(txt_Frequency.Text);

            fluxDensity = Double.Parse(txt_Fluxdensity.Text);

            delta = Double.Parse(txt_123.Text);

            temperatureRise = Double.Parse(txt_tm.Text);

            ambTemperature = Double.Parse(txt_tr.Text);

            Wi = Double.Parse(txt_Wi.Text);

            Ai = Double.Parse(txt_Ai.Text);

            GiPerGcu = Double.Parse(txt_Gi_Gcu.Text);

            lmtPerLi = Double.Parse(txt_LmtLi.Text);

            gcuPergi = Double.Parse(txt_gcugi.Text);

            CiPerCcu = Double.Parse(txt_CiCu.Text);

            x = Double.Parse(txt_Load.Text);

            DPera = Double.Parse(txt_Da.Text);

            AcuPerAi = Double.Parse(txt_AcuAi.Text);

            ks = Double.Parse(txt_Kc.Text);

            kc = Double.Parse(txt_Kc.Text);

            kw = Double.Parse(txt_Kw.Text);

            kFactor = Double.Parse(txt_Kfactor.Text);

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

            


            // you should add the rest of them
        }
    }
}