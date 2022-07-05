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
using Main;
using MathNet.Numerics;

using MathNet.Numerics.Interpolation;
// using Microsoft.VisualBasic.CompilerServices;

namespace testmna
{
    public partial class FlatArmature : Form
    {
        private double u = 4e-7;

        private double gravityForce = 9.81;

        private bool isNeuton;

        private double force;

        private double stroke;

        private double voltage;

        private double temperature;

        private double ambientTemperature;

        private double ssf;

        private double heightToDepthRatio;

        private double dutyCycle;

        private double Allowance;

        private double Topcompressboardinsulation;

        private double Bottomcompressboardinsulation;

        private double Spoolthickness;

        private double Insulationbetweencoilandspool;

        private double Externalinsulation;

        private int SWGAWGBWGIndex = -1;

        private List<double> swgInsulations = new List<double>();
        private List<double> awgInsulations = new List<double>();

        private int iteration;
        private double accurcy;

        private double nextIterVal;

        private double pho2;

        private double h;

        private double dc;

        private double r1;

        private double r2;

        private double r3;

        private double t1;

        private double t2;

        private double d;

        private double di;

        private double NetheightOfCoil;

        private double Numberofroundsperlayer;

        private double NetDepthOfCoil;

        private double NumberOfLayer;

        private double N;

        private double az;

        private double lmt;

        private double R;

        private double I;

        private double P;

        private double actualMMF;


        private List<double> errors ;
        private List<double> mmfs ;
        private List<double> hratios;








        public FlatArmature(double force, double stroke, bool isMass)
        {

            InitializeComponent();

            isNeuton = !isMass;

            force *= isMass ? 1 : 9.81;

            txtForce.Text = Convert.ToString(force);

            txtStroke.Text = Convert.ToString(stroke);

            comboBox1.SelectedIndex = isMass ? 0 : 1;

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

            chkDutyCycle.SelectedIndex = 0;
            wireGauge.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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



        private void button1_Click(object sender, EventArgs e)
        {

            errors = new List<double>();
            hratios = new List<double>();
            mmfs = new List<double>();
            getValues();
            for (int i = 0; i < iteration; i++)
            {
                // addad shakhes ra hesab mikonim
                double IndexNumber = Math.Sqrt(force) / stroke;


                // Bg az chegali favaran vs sqrt force over tool fasele havayi
                double Bg = getModel(@"Resources\\Bg.txt").Interpolate(IndexNumber);


                // calc r1
                if (isNeuton)
                {
                    r1 = Math.Sqrt((force * u) / (Math.Pow(Bg, 2) * Math.PI)) * 100;
                }
                else
                {
                    r1 = Math.Sqrt((force * u * gravityForce) / Math.Pow(Bg, 2)) * 100;
                }



                double mmf;
                if (method1.Checked)
                {
                    // 1.2 -> 1.35
                    double value = nextIterVal == 0 ? 1.2 : nextIterVal;
                    mmf = 16e5 * stroke / 100 * Bg * value;

                }
                else 
                {
                    mmf = (16e5 * stroke / 100 * Bg + 8000 * r1 / 100);
                }
               


                mmfs.Add(mmf);

                double pho = 2.1e-6;
                double RT1 = 234.5 + temperature;
                double RT2 = 234.5 + (temperature + ambientTemperature);
                pho2 = pho / (RT1 / RT2);




                // TODO landa bayad az nemoydar khiz va dama 
               
                double lambda = getModel(@"Resources\\lambda.txt").Interpolate(temperature);




                // h^2 ( r2 - r1 )
                // validatio ssf (0.5 - 0.7)  0.5 -> >100   0.7 -> <100

                double vahidValue = (dutyCycle * pho2 * Math.Pow(mmf, 2)) / (2 * lambda * ssf * temperature);

                if (!rdbfixTheFactor.Checked)
                {
                    heightToDepthRatio = nextIterVal == 0 ? heightToDepthRatio : heightToDepthRatio + nextIterVal;
                }

                hratios.Add(heightToDepthRatio);
                // r2 -r1 =dc
                dc = Math.Pow(vahidValue / (heightToDepthRatio * heightToDepthRatio), (double)1 / 3);


                r2 = dc + r1;


                // h/ (r2-r1 ) = heightToDepthRatio
                h = heightToDepthRatio * dc;



                // r3 = sqrt (r1^2 +r2 ^2 ) 
                r3 = Math.Sqrt(Math.Pow(r1, 2) + Math.Pow(r2, 2));



                t1 = r1 / 2;



                t2 = Math.Pow(r1, 2) / (2 * r2);


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



                NetheightOfCoil = h - ((Topcompressboardinsulation + Bottomcompressboardinsulation + Allowance) * Math.Pow(10, -1));



                Numberofroundsperlayer = (int)(NetheightOfCoil / (di / 10));



                // TODO rename callaf
                NetDepthOfCoil = dc - ((Spoolthickness + Insulationbetweencoilandspool + Externalinsulation) * Math.Pow(10, -1));



                NumberOfLayer = (int)(NetDepthOfCoil / (di / 10));



                N = Numberofroundsperlayer * NumberOfLayer;



                az = (Math.PI / 4) * Math.Pow(d, 2);



                lmt = Math.PI * (r1 + r2);


                // Resistance
                R = (pho2 * lmt * N) / (az * 0.01);


                // current
                I = voltage / R;



                //  talafat
                P = R * Math.Pow(I, 2);



                actualMMF = N * I;

                double error = Math.Abs(((actualMMF - mmf) / mmf)) * 100;
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
                        double value = 1.35 - 1.2;
                        nextIterVal = value / iteration;
                    }
                    else if (rdbuseDefaultValue.Checked)
                    {
                        double value = heightToDepthRatio - 0;
                        nextIterVal = value / iteration;
                    }
                    else
                    {
                        double value = heightToDepthRatio - 3;
                        nextIterVal = value / iteration;
                    }

                }
            }





            lblPicr1.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r1));

            lblPicr2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r2));

            lblPicr3.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r3));

            lblPicT2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t1));

            lblPicT2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t2));

            lblPicStroke.Text = "= " + Convert.ToString(string.Format("{0:0.00}", stroke));

            lblPicN2.Text = "= " + Convert.ToString(string.Format("{0:0}", N));

            lblPicH.Text = "= " + Convert.ToString(string.Format("{0:0.00}", h));

            lbldc.Text = "= " + Convert.ToString(string.Format("{0:0.00}", dc));


            dataGridView3.Rows.Clear();

            dataGridView3.Rows.Add("  pho2", "  ohm_cm", string.Format("  {0:0.00000000}", pho2));

            dataGridView3.Rows.Add("  h", "  cm", string.Format("  {0:0.0000}", h));

            dataGridView3.Rows.Add("  dc", "  cm", string.Format("  {0:0.0000}", dc));

            dataGridView3.Rows.Add("  r1", "  cm", string.Format("  {0:0.0000}", r1));

            dataGridView3.Rows.Add("  r2", "  cm", string.Format("  {0:0.0000}", r2));

            dataGridView3.Rows.Add("  r3", "  cm", string.Format("  {0:0.0000}", r3));

            dataGridView3.Rows.Add("  t1", "  cm", string.Format("  {0:0.0000}", t1));

            dataGridView3.Rows.Add("  t2", "  cm", string.Format("  {0:0.0000}", t2));

            dataGridView3.Rows.Add("  d", "  cm", string.Format("  {0:0.0000}", d));

            dataGridView3.Rows.Add("  di", "  cm", string.Format("  {0:0.0000}", di));

            dataGridView3.Rows.Add("  NetheightOfCoil", "", string.Format("  {0:0}", NetheightOfCoil));

            dataGridView3.Rows.Add("  Numberofroundsperlayer", "", string.Format("  {0:0}", Numberofroundsperlayer));

            dataGridView3.Rows.Add("  NetDepthOfCoil", "", string.Format("  {0:0}", NetDepthOfCoil));

            dataGridView3.Rows.Add("  NumberOfLayer", "", string.Format("  {0:0}", NumberOfLayer));

            dataGridView3.Rows.Add("  N", "", string.Format("  {0:0.0000}", N));

            dataGridView3.Rows.Add("  az", "  cm^2", string.Format("  {0:0.0000}", az));

            dataGridView3.Rows.Add("  lmt", "  cm", string.Format("  {0:0.0000}", lmt));

            dataGridView3.Rows.Add("  R", "  ohm", string.Format("  {0:0.0000}", R));

            dataGridView3.Rows.Add("  I", "  Amper", string.Format("  {0:0.0000}", I));

            dataGridView3.Rows.Add("  actualMMF", "  A", string.Format("  {0:0}", actualMMF));

            dataGridView3.Rows.Add("  index", " ", string.Format("  {0:0}", SWGAWGBWGIndex));



            chart1.Series["error"].Points.Clear();
            chart2.Series["mmf"].Points.Clear();
            chart3.Series["HeighttoDepthRatio"].Points.Clear();
            for (int i = 0; i < errors.Count; i++)
            {
                chart1.Series["error"].Points.AddXY(i, errors[i]);
                chart2.Series["mmf"].Points.AddXY(i, mmfs[i]);
                chart3.Series["HeighttoDepthRatio"].Points.AddXY(i, hratios[i]);
            }
            

            //cvn
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

            voltage = Double.Parse(txtVolyage.Text);

            temperature = Double.Parse(txtTemperature.Text);

            ambientTemperature = Double.Parse(txtAmbientTemp.Text);

            ssf = Double.Parse(txtslotSpaceFactor.Text);

            heightToDepthRatio = Double.Parse(txtHeightToDepthRatio.Text);

            dutyCycle = Double.Parse(chkDutyCycle.Text);

            Topcompressboardinsulation = Double.Parse(text_1.Text);

            Bottomcompressboardinsulation = Double.Parse(text_2.Text);

            Allowance = Double.Parse(text_3.Text);

            Spoolthickness = Double.Parse(text_4.Text);

            Insulationbetweencoilandspool = Double.Parse(text_5.Text);

            Externalinsulation = Double.Parse(txtExternalInsulution.Text);

            accurcy = Double.Parse(txtaccuracy.Text);

            iteration = Convert.ToInt32(txtmaximumIteration.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                isNeuton = false;
                lblForce.Text = "Kg";
            }
            else
            {
                isNeuton = true;
                lblForce.Text = "N";
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

        private void method1_CheckedChanged(object sender, EventArgs e)
        {
            if (method1.Checked)
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }
        }

        private void method2_CheckedChanged(object sender, EventArgs e)
        {
            if (method2.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }
    }
    }


