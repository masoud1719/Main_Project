using iTextSharp.text;
using iTextSharp.text.pdf;
using MathNet.Numerics;
using MathNet.Numerics.Interpolation;
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

namespace testmna
{

    public partial class Plunger : Form
    {


        private double F;
        private double g;
        private double V;
        private double Tm;
        private double Ta;
        private double q;
        private double Alpha;
        private double Inferior;
        private double leakagefactor;
        private double K;
        private double L;
        private double M;
        private double X;
        private double O;
        private double P;
        private double Q;
        private double accuracy;
        private double MaximumIteration;
        private bool isNeuton;
        private double ssf;


      

        private int SWGAWGBWGIndex = -1;

        private List<double> swgInsulations = new List<double>();
        private List<double> awgInsulations = new List<double>();
        private double nextIterVal;
        private double r1;
        private double r2;
        private double r3;
        private double t1;
        private double t2;
        private double t3;
        private double t4;
        private double t5;
        private double t6;
        private double stroke;
        private double N;
        private double hc;
        private double dc;
        private double lg;
        private double lgc;
        private double d;
        private double di;
        private double Ro2;
        private double Numberoflayersdephtwise;
        private double Netwindingdepht;
        private double Numberoflayersheightwise;
        private double az;
        private double lmt;
        private double R;
        private double I;
        private double actualMMF;
        private double A;
        private double mmf;
        private double Ro1;
        private double Netwindingheight;
        private double Bg;
        private double Lambda;


        private List<double> errors = new List<double>();
        private List<double> mmfs = new List<double>();
        private List<double> hratios = new List<double>();

        


        private void cmb_force_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Mass"))
                lblForce.Text = "kg";
            else
                lblForce.Text = "N";
        }





        public Plunger(double force, double stroke, bool isMass)
        {
            InitializeComponent();
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


            txt_wire.SelectedIndex = 0;
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
            for (int i = 0; i < MaximumIteration; i++)
            {


                // kg/cm
                var IndexNumber = Math.Sqrt(F) / stroke;


                Bg = getModel(@"Resources\\Bg.txt").Interpolate(IndexNumber);

                // Area of plunger..........m^2
                A = (F * 4 * Math.PI * Math.Pow(10, -7)) / (0.051 * Math.Pow(Bg, 2));


                // Radius of plunger.........cm
                r1 = Math.Sqrt(A / Math.PI) * 100;


                double value;
                if (method1.Checked)
                {
                    // 1.1 -> 1.2
                    value = nextIterVal == 0 ? 1.1 : nextIterVal;
                    mmf = 16e5 * stroke / 100 * Bg * value;

                }
                else
                {
                    mmf = (16e5 * (stroke / 100) * Bg) / 0.7;
                }




                mmfs.Add(mmf);



                // برای دمای 75 درجه سانتیگراد .......واحد: اهم_سانتیمتر
                Ro1 = 2.1 * Math.Pow(10, -6);



                // اگر دما از 75 درجه سانتی گراد تغییر کرد، بر اساس فرمول زیر مقدار جدید را بدست می آوریم
                // طبق فرمول زیر ارتفاع سیم پیچی را حساب می کنیم .......واحد: اهم_سانتیمتر
                Ro2 = Ro1 * (234.5 + Tm + Ta) / (234.5 + 75);


                if (!rdbfixTheFactor.Checked)
                {
                    Alpha = nextIterVal == 0 ? Alpha : Alpha + nextIterVal;
                }

                hratios.Add(Alpha);


                Lambda = getModel(@"Resources\\lambda.txt").Interpolate(Tm);

                // واحد: سانتی متر
                hc = Math.Pow(((q * Ro2 * Math.Pow(mmf, 2) * Alpha) / (2 * Lambda * ssf * Tm)), (double)1 / 3);



                // واحد: سانتی متر
                dc = hc / Alpha;



                // واحد: سانتی متر
                r2 = dc + r1;



                // واحد: سانتی متر
                r3 = Math.Sqrt(((Inferior / 100) * Math.Pow(r1, 2)) + Math.Pow(r2, 2));



                // واحد: سانتی متر
                t1 = ((Inferior / (100 * 2)) * r1);


                // واحد: سانتی متر
                t2 = ((Inferior / (100 * 2)) * (Math.Pow(r1, 2) / r2));


                t4 = (1.25 * r1 * r1) / ((r3 * r3) - (r2 * r2));


                t3 = (1.25 * r1 * r1) / (lgc + r1 + t4);


                // واحد: وبر
                double phi0 = leakagefactor * Math.PI * Math.Pow(r1, 2) * Math.Pow(10, -4) * Bg;



                // واحد: میلی متر
                lgc = K + L;




                double mmfgc = 0.1 * mmf;



                // واحد: سانتی متر
                t5 = ((800000 * phi0 * lgc * Math.Pow(10, -3)) / (mmfgc)) * 100;

                
                t6 = (0.625 * r1 * r1) / r2;  














                // واحد: متر مربع
                double Areaoffluxpatchthoughcylindricalgap = Math.PI * ((2 * r1) + lgc) * t5 * Math.Pow(10, -5);



                // واحد: وبر بر متر مربع
                double Bgc = phi0 / Areaoffluxpatchthoughcylindricalgap;



                // واحد: میلیمتر
                d = Math.Sqrt((4 * Ro2 * mmf * (r2 - r1)) / V) * 10;


                double fileD;
                if (txt_wire.SelectedIndex == 0)
                {
                    fileD = getDFromFile(@"Resources\\SWG.txt", (double)d);
                }
                else if (txt_wire.SelectedIndex == 1)
                {
                    fileD = getDFromFile(@"Resources\\AWG.txt", (double)d);
                }
                else
                {
                    fileD = getDFromFile(@"Resources\\BWG.txt", (double)d);
                }



                double plus = 0.2;
                if (txt_wire.SelectedIndex == 0 || txt_wire.SelectedIndex == 1)
                {
                    plus = swgInsulations[SWGAWGBWGIndex];
                }

                di = (fileD) + plus;






                double TotalAllowance = K + L + M + X + O;




                Netwindingdepht = dc - (TotalAllowance / 10);




                Numberoflayersdephtwise = Math.Round(Netwindingdepht / (di / 10));




                Netwindingheight = ((hc * 10) - P) - (2 * Q);




                Numberoflayersheightwise = Math.Round(Netwindingheight / di);




                N = Numberoflayersdephtwise * Numberoflayersheightwise;




                az = (Math.PI / 4) * Math.Pow(d, 2);




                lmt = Math.PI * (r1 + r2);




                R = (Ro2 * lmt * N) / (az * 0.01);




                I = (V / R) * 10;






                actualMMF = N * I;
                double error = Math.Abs((actualMMF - mmf) / mmf) * 100;

                errors.Add(error);
                if (error < accuracy)
                {
                    break;
                }
                else
                {
                    if (rdbfixTheFactor.Checked)
                    {
                        method1.Checked = true;
                        value = 1.2 - 1.1;
                        nextIterVal = value / MaximumIteration;
                    }
                    else if (rdbuseDefaultValue.Checked)
                    {
                        value = Alpha - 0;
                        nextIterVal = value / MaximumIteration;
                    }
                    else
                    {
                        value = Alpha - 3;
                        nextIterVal = value / MaximumIteration;
                    }

                }

            }



            MessageBox.Show("Calculation Finished", "Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);




            lblPicr1.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r1));

            lblPicr2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r2));

            lblPicr3.Text = "= " + Convert.ToString(string.Format("{0:0.00}", r3));

            lblPicT1.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t1));

            lblPicT2.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t2));

            lblPicT3.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t3));

            lblPicT4.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t4));

            lblPicT5.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t5));

            lblPicT6.Text = "= " + Convert.ToString(string.Format("{0:0.00}", t6));

            lblPicLgc.Text = "= " + Convert.ToString(string.Format("{0:0.00}", lgc));

            lblPicN2.Text = "= " + Convert.ToString(string.Format("{0:0}", N));

            lblPicH.Text = "= " + Convert.ToString(string.Format("{0:0.00}", hc));

            lbldc.Text = "= " + Convert.ToString(string.Format("{0:0.00}", dc));

            lblLg.Text = "= " + Convert.ToString(string.Format("{0:0.00}", stroke));





            dataGridView3.Rows.Clear();

            dataGridView3.Rows.Add("  pho2", "  ohm_cm", string.Format("  {0:0.00000000}", Ro2));

            dataGridView3.Rows.Add("  Bg", "  Wb/m^2", string.Format("  {0:0.0000}", Bg));

            dataGridView3.Rows.Add("  mmf", "  A", string.Format("  {0:0.0000}", mmf));

            dataGridView3.Rows.Add("  Lambda", "  wat_cm^2/°C", string.Format("  {0:0.000000}", Lambda));

            dataGridView3.Rows.Add("  dc", "  cm", string.Format("  {0:0.0000}", dc));

            dataGridView3.Rows.Add("  hc", "  cm", string.Format("  {0:0.0000}", hc));

            dataGridView3.Rows.Add("  r1", "  cm", string.Format("  {0:0.0000}", r1));

            dataGridView3.Rows.Add("  r2", "  cm", string.Format("  {0:0.0000}", r2));

            dataGridView3.Rows.Add("  r3", "  cm", string.Format("  {0:0.0000}", r3));

            dataGridView3.Rows.Add("  t1", "  cm", string.Format("  {0:0.0000}", t1));

            dataGridView3.Rows.Add("  t2", "  cm", string.Format("  {0:0.0000}", t2));

            dataGridView3.Rows.Add("  t3", "  cm", string.Format("  {0:0.0000}", t3));

            dataGridView3.Rows.Add("  t4", "  cm", string.Format("  {0:0.0000}", t4));

            dataGridView3.Rows.Add("  t5", "  cm", string.Format("  {0:0.0000}", t5));

            dataGridView3.Rows.Add("  t6", "  cm", string.Format("  {0:0.0000}", t6));

            dataGridView3.Rows.Add("  d", "  mm", string.Format("  {0:0.0000}", d));

            dataGridView3.Rows.Add("  di", "  mm", string.Format("  {0:0.0000}", di));

            dataGridView3.Rows.Add("  Net winding depht", "  cm", string.Format("  {0:0.0000}", Netwindingdepht));

            dataGridView3.Rows.Add("  Number of layers depht wise", "", string.Format("  {0:0}", Numberoflayersdephtwise));

            dataGridView3.Rows.Add("  Net winding height", "  cm", string.Format("  {0:0.0000}", Netwindingheight));

            dataGridView3.Rows.Add("  Number of layers height wise", "", string.Format("  {0:0}", Numberoflayersheightwise));

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

            F = Double.Parse(txtForce.Text);
            if (isNeuton)
            {
                F /= 9.81;
            }

            stroke = Double.Parse(txtStroke.Text);

            V = int.Parse(txtVolyage.Text);

            Tm = int.Parse(Temperature.Text);

            Ta = int.Parse(txtAmbientTemp.Text);

            q = Double.Parse(txt_Intermittentraiting.Text);

            Alpha = int.Parse(txtHeightToDepthRatio.Text);

            Inferior = int.Parse(txt_inferior.Text);

            leakagefactor = Double.Parse(txt_leakage.Text);

            K = Double.Parse(txt_thickness.Text);

            L = Double.Parse(txt_plunger.Text);

            M = Double.Parse(txt_brass.Text);

            X = Double.Parse(txt_outside.Text);

            O = Double.Parse(txt_allowance_irr.Text);

            P = Double.Parse(txt_allowance_mica.Text);

            Q = Double.Parse(txt_allowance_fibr.Text);

            accuracy = Double.Parse(txt_accuracy.Text);

            MaximumIteration = Convert.ToInt32(text_Maxiteration.Text);

            ssf = Double.Parse(txtslotSpaceFactor.Text);


        }




        





        private void btnExport_Click_1(object sender, EventArgs e)
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
                        MessageBox.Show("You have successfully exported the file.", "PDF Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void Plunger_Load(object sender, EventArgs e)
        {
            txt_wire.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
    }
    }


    