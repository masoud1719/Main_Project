using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.Interpolation;

namespace second
{
    public partial class HorseShoe : Form
    {
        private double force;

        private double stroke;

        private double voltage;

        private double temp;

        private double ambTemp;

        private double permeability;

        private double fluxDensityofCore;

        private double yokeLeakageFactor;

        private double armutureLeakageFactor;

        private double heightTODepthRation;

        private double slotSpaceFactor;

        private double coilsHeight;

        private double coilsTube;

        private double allowance;

        private double clearance;

        private double spoolThickness;

        private double coilSpoolInsulation;

        private double coilCoverThickness;

        private double totalRadiusInsulation;

        private double totalVetcalInsulation;

        private double faceofPoleThickness;

        private double accurcy;

        private double maximumIteration;

        private double intermittentRating;

        private bool isNeuton;

        private double nextIterVal;
        private double pho2;
        private double r1;
        private double radiusofPoleCore;
        private double r2;
        private double t;
        private double t1;
        private double t2;
        private double rDiff;
        private double h;
        private double d;
        private double di;
        private double netHeightofCoil;
        private double numberofLayerDepth;
        private double netwindingDepth;
        private double numberofLayerHeightWise;
        private double N;
        private double az;
        private double lmt;
        private double R;
        private double I;





        private double u0 = 4 * Math.PI * Math.Pow(10, -7);

        private int SWGAWGBWGIndex = -1;

        private List<double> swgInsulations = new List<double>();
        private List<double> awgInsulations = new List<double>();


        private List<double> errors = new List<double>();
        private List<double> mmfs = new List<double>();
        private List<double> hratios = new List<double>();








        public HorseShoe(double force, double stroke, bool isMass)
        {

            InitializeComponent();

            isNeuton = !isMass;

            force *= isMass ? 1 : 9.81;

            txtForce.Text = Convert.ToString(force);

            txtStroke.Text = Convert.ToString(stroke);

            forceTypeCombo.SelectedIndex = isMass ? 0 : 1;

            creteSWGInsulations();
            cretwAWGInsulation();
        }

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
        }



        





        

        private void btncalc_Click(object sender, EventArgs e, int SWGAWGBWGIndex)
        {
            getValues();
            // addad shakhes ra hesab mikonim
            double IndexNumber = Math.Sqrt(force) / stroke;



            double Bg = getModel(@"Resources\\Bg.txt").Interpolate(IndexNumber);

            // A....m^2
            double areaofEachPoleFace = ((force * u0) / (0.102 * Math.Pow(Bg, 2)));

            // W......m
            double widthofPoleFace = Math.Sqrt(areaofEachPoleFace);

            // sqrA * sqrA.........m^2
            double actualAreaofPoleFace = widthofPoleFace * widthofPoleFace;


            double fluxIntheAirGap = actualAreaofPoleFace * Bg;

            // wb
            double fluxatTheBaseofPoles = yokeLeakageFactor * fluxIntheAirGap;


            double areaofPoleCore = fluxatTheBaseofPoles / fluxDensityofCore;

            //r1..........mm
            radiusofPoleCore = Math.Sqrt(areaofPoleCore / Math.PI) *1000;


            // 1.1 ---- 1.2
            double value = nextIterVal == 0 ? 1.1 : nextIterVal;
            double mmf = 16e5 * stroke / 100 * Bg * 1.1;





            double pho = 2.1e-6;


            double RT1 = 234.5 + 75;


            double RT2 = 234.5 + (temp + ambTemp);


            double pho2 = pho / (RT1 / RT2);




            if (!rdbfixTheFactor.Checked)
            {
                heightTODepthRation = nextIterVal == 0 ? heightTODepthRation : heightTODepthRation + nextIterVal;
            }

            hratios.Add(heightTODepthRation);


            double lambda = getModel(@"Resources\\lambda.txt").Interpolate(temp);

            //cm
            double vahidValue = (intermittentRating * pho2 * Math.Pow(mmf, 2)) / (2 * lambda * slotSpaceFactor * temp);


            rDiff = Math.Pow(vahidValue / (heightTODepthRation * heightTODepthRation), (double)1 / 3);


            r2 = rDiff + radiusofPoleCore;


            h = heightTODepthRation * rDiff;


            t2 = (Math.Pow(radiusofPoleCore, 2) * Math.PI) / widthofPoleFace;

            // d.............mm
            d = Math.Sqrt((4 * pho2 * (radiusofPoleCore + r2) * mmf) / voltage) * 10;



            double fileD;
            if (wireGauge.SelectedIndex == 0)
            {
                fileD = getDFromFile(@"Resources\\SWG.txt", d);
            }
            else if (wireGauge.SelectedIndex == 1)
            {
                fileD = getDFromFile(@"Resources\\AWG.txt", d);
            }
            else
            {
                fileD = getDFromFile(@"Resources\\BWG.txt", d);
            }



            double plus = 0.2;
            if (wireGauge.SelectedIndex == 0 || wireGauge.SelectedIndex == 1)
            {
                plus = swgInsulations[SWGAWGBWGIndex];
            }

            di = (fileD * 10) + plus;


            double fluxInArmiture = armutureLeakageFactor * fluxIntheAirGap;


            double areaofArmiture = fluxInArmiture / fluxDensityofCore;


            t1 = areaofArmiture / (widthofPoleFace * Math.Pow(10, -3));


            t = t2 / 2;


            netHeightofCoil = h - (2 * coilsHeight);


            numberofLayerDepth = (int)netHeightofCoil / (di * 10);


            netwindingDepth = (rDiff / 10) -  (coilsTube + coilCoverThickness );


            numberofLayerHeightWise = (int)netwindingDepth / di;


            N = numberofLayerHeightWise * numberofLayerDepth;


            az = (Math.PI / 4) * d * d;


            lmt = Math.PI * (radiusofPoleCore + r2);


            R = (pho2 * lmt * N) / az;


            I = voltage / R;


            double actualMMF = N * I;
            double error = ((actualMMF - mmf) / mmf) * 100;
            errors.Add(error);
            if (error < accurcy)
            {
                // اینجا با فلت آرمیچر قرق داره
                accurcy = error;
            }
            else
            {
                if (rdbfixTheFactor.Checked)
                {
                    method1.Checked = true;
                    value = 1.2 - 1.1;
                    nextIterVal = value / maximumIteration;
                }
                else if (rdbuseDefaultValue.Checked)
                {
                    value = heightTODepthRation - 0;
                    nextIterVal = value / maximumIteration;
                }
                else
                {
                    value = heightTODepthRation - 3;
                    nextIterVal = value / maximumIteration;
                }

            }


            
        }




        








        private double getDFromFile(string v, double d)
        {
            throw new NotImplementedException();
        }

        private IInterpolation getModel(String filePath)
        {
            var x = new List<double>();
            var y = new List<double>();
            using (var streamReader = new StreamReader(filePath))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    x.Add(Double.Parse(arr[0]));
                    y.Add(Double.Parse(arr[1]));
                }
            }
            return Interpolate.CubicSpline(x.AsEnumerable(), y.AsEnumerable());
        }




            private double getMMFFromBHCurve()
        {
            return 0;
        }

        private void getValues()
        {
            force = Double.Parse(txtForce.Text);
            if (isNeuton)
            {
                force /= 9.81;
            }

            stroke = Double.Parse(txtStroke.Text);
            stroke *= Math.Pow(10, -2);

            voltage = Double.Parse(txtVoltage.Text);

            temp = Double.Parse(txtTemperature.Text);

            ambTemp =Double.Parse(AmbientTemperature.Text);

            fluxDensityofCore = Double.Parse(txtFluxDensityofCore.Text);

            yokeLeakageFactor = Double.Parse(txtYokeleakageFactor.Text);

            armutureLeakageFactor =Double.Parse(txtArmetureLeacageFactor.Text);

            heightTODepthRation = Double.Parse(txtHeightToDepthRatio.Text);

            slotSpaceFactor =Double.Parse(txtslotSpaceFactor.Text);

            coilsHeight =Double.Parse(txtCoilsheight.Text);

            coilsTube = Double.Parse(txtCoilsTube.Text);

            allowance = Double.Parse(txtAllowance.Text);

            clearance = Double.Parse(txtClearance.Text);

            spoolThickness = Double.Parse(txtSpoolThickness.Text);

            coilSpoolInsulation =Double.Parse(txtCoilsSpoolInsulation.Text);

            spoolThickness = Double.Parse(txtCoilsCoverThickness.Text);

            totalRadiusInsulation=Double.Parse(txtTotalRadusInsulation.Text);

            totalVetcalInsulation = Double.Parse(txtTotalVerticalInsulation.Text);

            faceofPoleThickness = Double.Parse(txtFaceofPoleThickness.Text);

            accurcy = Double.Parse(txtAccuracy.Text);
               
            maximumIteration = Convert.ToInt32(txtMaximumIteration.Text);

            intermittentRating = Double.Parse(txtIntermittedRating.Text);

        }



        













        private void forceTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forceTypeCombo.SelectedIndex == 0)
            {
                lblForce.Text = "Kg";
                isNeuton = false;
            }
            else
            {
                lblForce.Text = "N";
                isNeuton = true;
            }
        }

    }
}
