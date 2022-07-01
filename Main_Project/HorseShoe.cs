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
using iTextSharp.text;
using iTextSharp.text.pdf;
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

        private double fluxDensityofCore;

        private double yokeLeakageFactor;

        private double armutureLeakageFactor;

        private double heightTODepthRation;

        private double slotSpaceFactor;

        private double coilsHeight;

        private double coilsTube;


        private double accurcy;

        private double maximumIteration;

        private double intermittentRating;

        private bool isNeuton;

        private double nextIterVal;
        private double pho2;
        private double r1;
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
        private double D;
        private double W;
        private double P;
        private double actualMMF;
        private double Box1;
        private double widthofPoleFace;
        private double coilCoverThickness;
        private double Bg;
        private double mmf;
        private double Lambda;
        private double dc;





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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


        private double GetDFromFile(string v, double d)
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





        private double getDFromFile(string filePath, double value)
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
            SWGAWGBWGIndex = (int)first[second.IndexOf(res)];
            return res;
        }





        private void btncalc_Click(object sender, EventArgs e)
        {
            errors = new List<double>();
            hratios = new List<double>();
            mmfs = new List<double>();

            getValues();
            for (int i = 0; i < maximumIteration; i++)
            {

                // addad shakhes ra hesab mikonim
                double IndexNumber = Math.Sqrt(force) / stroke;



                Bg = getModel(@"Resources\\Bg.txt").Interpolate(IndexNumber);

                // A....m^2
                double areaofEachPoleFace = ((force * u0) / (0.102 * Math.Pow(Bg, 2)));

                // W......m
                widthofPoleFace = Math.Sqrt(areaofEachPoleFace);

                // sqrA * sqrA.........m^2
                double actualAreaofPoleFace = widthofPoleFace * widthofPoleFace;

                // wb
                double fluxIntheAirGap = actualAreaofPoleFace * Bg;

                // wb/m^2
                double fluxatTheBaseofPoles = yokeLeakageFactor * fluxIntheAirGap;

                //m^2
                double areaofPoleCore = fluxatTheBaseofPoles / fluxDensityofCore;

                //r1..........cm
                r1 = Math.Sqrt(areaofPoleCore / Math.PI) * 100;


                // 1.1 ---- 1.2

                

                double value;
                if (method1.Checked)
                {
                    // 1.1 -> 1.2
                    value = nextIterVal == 0 ? 1.1 : nextIterVal;
                    mmf = 16e5 * stroke / 100 * Bg * value;

                }
                else
                {
                    mmf = (16e5 * (stroke / 100) * Bg) / 0.8;
                }



                mmfs.Add(mmf);




                double pho = 2.1e-6;


                double RT1 = 234.5 + 75;


                double RT2 = 234.5 + (temp + ambTemp);


                pho2 = pho / (RT1 / RT2);




                if (!rdbfixTheFactor.Checked)
                {
                    heightTODepthRation = nextIterVal == 0 ? heightTODepthRation : heightTODepthRation + nextIterVal;
                }

                hratios.Add(heightTODepthRation);


                Lambda = getModel(@"Resources\\lambda.txt").Interpolate(temp);


                //cm
                double h1 = ((intermittentRating * pho2 * Math.Pow(mmf, 2) * heightTODepthRation) / (2 * Lambda * slotSpaceFactor * temp));


                h = Math.Pow(h1, (double)1 / 3);


                dc = h * (1 / heightTODepthRation);


                r2 = dc + r1;


                


                t2 = (r1 * r1 * Math.PI)  / (widthofPoleFace * 100);

                // d.............mm
                d = Math.Sqrt((4 * pho2 * (r1 + r2) * mmf) / voltage) * 10;
                


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

                di = (fileD) + plus;


                double fluxInArmiture = armutureLeakageFactor * fluxIntheAirGap;


                double areaofArmiture = fluxInArmiture / fluxDensityofCore;


                t1 = (areaofArmiture / widthofPoleFace) * 100;


                t = t2 / 2;


                netHeightofCoil = h - (2 * coilsHeight / 10);


                numberofLayerDepth = Math.Round(netHeightofCoil * 10 / (di));


                netwindingDepth = dc - ((coilsTube + coilCoverThickness) / 10);



                numberofLayerHeightWise = Math.Round(netwindingDepth * 10 / di);


                N = numberofLayerDepth * numberofLayerHeightWise;

                // mm^2
                az = (Math.PI / 4) * d * d;


                D = (2 * r2) + (Box1 / 10);

                //cm
                lmt = Math.PI * (r1 + r2);


                R = (pho2 * lmt * N) / (az * 0.01);


                I = voltage / R;

                P = R * I * I;

                actualMMF = N * I;
                double error = ((actualMMF - mmf) / mmf) * 100;
                errors.Add(error);
                if (error < accurcy)
                {

                    break;
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




            dataGridView3.Rows.Clear();

            lblPicr1.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r1));

            lblPicr2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r2));

            lblPicT.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t));

            lblPicT1.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t1));

            lblPicT2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t2));

            lblPicStroke.Text = "= " + Convert.ToString(string.Format("{0:0.00}", stroke));

            label10.Text = "= " + Convert.ToString(string.Format("{0:0}", N));

            lblPicH.Text = "= " + Convert.ToString(string.Format("{0:0.00}", h));

            lblD.Text = "= " + Convert.ToString(string.Format("{0:0.00}", D));

            lbldc.Text = "= " + Convert.ToString(string.Format("{0:0.00}", (widthofPoleFace * 100)));






            dataGridView3.Rows.Clear();

            dataGridView3.Rows.Add("  pho2", "  ohm_cm", string.Format("  {0:0.00000000}", pho2));

            dataGridView3.Rows.Add("  Bg", "  Wb/m^2", string.Format("  {0:0.0000}", Bg));

            dataGridView3.Rows.Add("  mmf", "  A", string.Format("  {0:0.0000}", mmf));

            dataGridView3.Rows.Add("  Lambda", "  wat_cm^2/°C", string.Format("  {0:0.000000}", Lambda));

            dataGridView3.Rows.Add("  dc", "  cm", string.Format("  {0:0.0000}", dc));

            dataGridView3.Rows.Add("  h", "  cm", string.Format("  {0:0.0000}", h));

            dataGridView3.Rows.Add("  r1", "  cm", string.Format("  {0:0.0000}", r1));

            dataGridView3.Rows.Add("  r2", "  cm", string.Format("  {0:0.0000}", r2));

            dataGridView3.Rows.Add("  t1", "  cm", string.Format("  {0:0.0000}", t1));

            dataGridView3.Rows.Add("  t2", "  cm", string.Format("  {0:0.0000}", t2));

            dataGridView3.Rows.Add("  t", "  cm", string.Format("  {0:0.0000}", t));

            dataGridView3.Rows.Add("  d", "  mm", string.Format("  {0:0.0000}", d));

            dataGridView3.Rows.Add("  di", "  mm", string.Format("  {0:0.0000}", di));

            dataGridView3.Rows.Add("  netHeightofCoil", "  cm", string.Format("  {0:0.0000}", netHeightofCoil));

            dataGridView3.Rows.Add("  numberofLayerDepth", "", string.Format("  {0:0}", numberofLayerDepth));

            dataGridView3.Rows.Add("  netwindingDepth", "  cm", string.Format("  {0:0.0000}", netwindingDepth));

            dataGridView3.Rows.Add("  numberofLayerHeightWise", "", string.Format("  {0:0}", numberofLayerHeightWise));

            dataGridView3.Rows.Add("  N", "", string.Format("  {0:0}", N));

            dataGridView3.Rows.Add("  az", "  mm^2", string.Format("  {0:0.0000}", az));

            dataGridView3.Rows.Add("  lmt", "  cm", string.Format("  {0:0.0000}", lmt));

            dataGridView3.Rows.Add("  R", "  ohm", string.Format("  {0:0.0000}", R));

            dataGridView3.Rows.Add("  I", "  Amper", string.Format("  {0:0.0000}", I));

            dataGridView3.Rows.Add("  actualMMF", "  A", string.Format("  {0:0}", actualMMF));

            dataGridView3.Rows.Add("  Wire gauge index", " ", string.Format("  {0:0}", SWGAWGBWGIndex));





            chart1.Series["error"].Points.Clear();
            chart2.Series["mmf"].Points.Clear();
            chart3.Series["HeighttoDepthRatio"].Points.Clear();
            for (int i = 0; i < errors.Count; i++)
            {
                chart1.Series["error"].Points.AddXY(i, errors[i]);
                chart2.Series["mmf"].Points.AddXY(i, mmfs[i]);
                chart3.Series["HeighttoDepthRatio"].Points.AddXY(i, hratios[i]);
            }




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

            voltage = Double.Parse(txtVoltage.Text);

            temp = Double.Parse(txtTemperature.Text);

            ambTemp = Double.Parse(textAmbientTemperature.Text);

            fluxDensityofCore = Double.Parse(txtFluxDensityofCore.Text);

            yokeLeakageFactor = Double.Parse(txtYokeleakageFactor.Text);

            armutureLeakageFactor = Double.Parse(txtArmetureLeacageFactor.Text);

            heightTODepthRation = Double.Parse(txtHeightToDepthRatio.Text);

            slotSpaceFactor = Double.Parse(txtslotSpaceFactor.Text);

            coilsHeight = Double.Parse(txtCoilsheight.Text);

            coilsTube = Double.Parse(txtCoilsTube.Text);

            accurcy = Double.Parse(txtAccuracy.Text);

            maximumIteration = Convert.ToInt32(txtMaximumIteration.Text);

            intermittentRating = Double.Parse(txtIntermittedRating.Text);

            Box1 = Double.Parse(textBox1.Text);

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





        private void btnExport_Click(object sender, EventArgs e)
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

