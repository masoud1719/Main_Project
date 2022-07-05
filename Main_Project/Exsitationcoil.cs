using iTextSharp.text;
using iTextSharp.text.pdf;
using MathNet.Numerics;
using MathNet.Numerics.Interpolation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Excitation_Coil
{
    public partial class Exsitationcoil : Form
    {
        public Exsitationcoil()
        {
            InitializeComponent();
        }

        private int SWGAWGBWGIndex = -1;

        private List<double> swgInsulations = new List<double>();
        private List<double> awgInsulations = new List<double>();


        private List<double> errors = new List<double>();
        private List<double> mmfs = new List<double>();
        private List<double> hratios = new List<double>();




        private double W;
        private double L;
        private double H;
        private double vc;
        private double dc;
        private double d;
        private double di;
        private double lmt;
        private double ro;
        private double az;
        private double Nh;
        private double Nd;
        private double N;
        private double P;
        private double I;
        private double HD;
        private double R;
        private double actualMMF;
        private double mmf;
        private double Di;
        private double Do;
        private double tm;
        private double tr;
        private double dt;
        private double Velocity;
        private double Armatur;
        private double flux;
        private double leakage;
        private double v;
        private double p;
        private double Parallel;
        private double VoltDrop;








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



        





        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox3.Enabled = false;
            maskedTextBox4.Enabled = false;
            //maskedTextBox5.Enabled = false;
            maskedTextBox6.Enabled = false;
            maskedTextBox7.Enabled = false;


            if (comboBox2.Text == "Round Wire")
            {
                maskedTextBox3.Enabled = true;
                maskedTextBox4.Enabled = true;
            }
            else
            {
                //maskedTextBox5.Enabled = true;
                maskedTextBox6.Enabled = true;
                maskedTextBox7.Enabled = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox12.Enabled = false;

            if (radioButton7.Checked)
                maskedTextBox12.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox10.Enabled = false;
            maskedTextBox11.Enabled = false;
            wireGauge.Enabled = false;

            if (radioButton8.Checked)
                maskedTextBox10.Enabled = true;
            else if (radioButton9.Checked)
                maskedTextBox11.Enabled = true;
            else
                wireGauge.Enabled = true;
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            maskedVelocity.Enabled = false;
            maskedArmatur.Enabled = false;
            maskeflux.Enabled = false;
            maskedleakage.Enabled = false;
            txt_mmf.Enabled = false;
            maskedParallel.Enabled = false;


            if (checkBox2.Checked)
            {
                mmf = Double.Parse(txt_mmf.Text);
                txt_mmf.Enabled = true;
                maskedVelocity.Enabled = false;
                maskedArmatur.Enabled = false;
                maskeflux.Enabled = false;
                maskedleakage.Enabled = false;
                maskedParallel.Enabled = false;
            }
            else
            {
                txt_mmf.Enabled = false;
                maskedVelocity.Enabled = true;
                maskedArmatur.Enabled = true;
                maskeflux.Enabled = true;
                maskedleakage.Enabled = true;
                maskedParallel.Enabled = true;





            }
        }




        

        private void button1_Click(object sender, EventArgs e)
        {



            v = Double.Parse(textBox1.Text);
            p = Double.Parse(maskedTextBox1.Text);

            if (comboBox1.Text == "Generator")
            {
                vc = (0.8 * v) / p;
            }

            else
                vc = v / p;






            







            if (radioButton5.Checked)
            {


                if (comboBox2.Text == "Round Wire")
                    dc = 0.5;


                else
                    dc = 5;


            }

            else
            {


                dc = Double.Parse(maskedTextBox12.Text);


            }

            double ti = 0;
            if (radioButton8.Checked)
                ti = Double.Parse(maskedTextBox10.Text);



            // Insulation on wire diameter
            double iwd = 0;
            if (radioButton9.Checked)
                iwd = Double.Parse(maskedTextBox11.Text);



            H = Double.Parse(maskedTextBox5.Text);





            if (comboBox2.Text == "Round Wire")
            {


                Di = Double.Parse(maskedTextBox4.Text);
                Do = Double.Parse(maskedTextBox3.Text);



                lmt = Math.PI * ((Di + Do) / 2);
            }
            else
            {
                L = Double.Parse(maskedTextBox7.Text);
                W = Double.Parse(maskedTextBox6.Text);



                lmt = 2 * (L + W) + Math.PI * (dc + (2 * ti));
            }


            tm = Double.Parse(textBox2.Text);
            tr = Double.Parse(maskedTextBox2.Text);




            ro = 2.1 * Math.Pow(10, -6);

            if (tm + tr != 75)
                ro = ro * (234.5 + tm + tr) / (234.5 + 75);



            az = ((ro * lmt * mmf) / vc) * 100;



            // az......mm^2



            d = Math.Sqrt(4 * az / Math.PI);




            if (radioButton8.Checked)
            {
                di = d + (2 * ti);
            }

            else if (radioButton9.Checked)
            {
                di = d + iwd;
            }   




            else
            {
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
            }




            double ssf;
            if (!checkBox1.Checked)
            {
                ssf = Double.Parse(maskedTextBox9.Text);


            }
            else
            {
                if (comboBox2.Text == "Round Wire")
                {

                    if (radioButton1.Checked)
                        ssf = 0.906 * Math.Pow(d / di, 2);


                    else

                        ssf = 0.785 * Math.Pow(d / di, 2);
                }
               
            }


            Nh = Math.Round(H / (di / 10));
            Nd = Math.Round(dc / (di / 10));



            N = Nh * Nd;


            // watt
            P = (ro * lmt * mmf * mmf) / ((az * Math.Pow(10, -2) * N));



            I = P / vc;


            // cm^2
            double C = (lmt + Math.PI * dc) * H;




            if (maskedTextBox14.Text != "")
                HD = Double.Parse(maskedTextBox14.Text);


            else
                HD = P / C;


            // ohm
            R = (ro * lmt * N) / (az * Math.Pow(10, -2));



            actualMMF = N * I;









            label_w.Text = "= " + Convert.ToString(string.Format("{0:0.00}", W));

            label_L.Text = "= " + Convert.ToString(string.Format("{0:0.00}", L));

            label_H.Text = "= " + Convert.ToString(string.Format("{0:0.00}", H));














            dataGridView3.Rows.Clear();

            dataGridView3.Rows.Add("  Pho2", "  ohm_cm", string.Format("  {0:0.00000000}", ro));

            dataGridView3.Rows.Add("  W", "  cm", string.Format("  {0:0.0000}", W));

            dataGridView3.Rows.Add("  L", "  cm", string.Format("  {0:0.0000}", L));

            dataGridView3.Rows.Add("  H", "  cm", string.Format("  {0:0.0000}", H));

            dataGridView3.Rows.Add("  vc", "  cm", string.Format("  {0:0.0000}", vc));

            dataGridView3.Rows.Add("  d", "  cm", string.Format("  {0:0.0000}", d));

            dataGridView3.Rows.Add("  di", "  cm", string.Format("  {0:0.0000}", di));

            dataGridView3.Rows.Add("  dc", "  cm", string.Format("  {0:0.0000}", dc));

            dataGridView3.Rows.Add("  lmt", "  cm", string.Format("  {0:0.0000}", lmt));

            dataGridView3.Rows.Add("  az", "  cm^2", string.Format("  {0:0.0000}", az));

            dataGridView3.Rows.Add("  Nh", "", string.Format("  {0:0}", Nh));

            dataGridView3.Rows.Add("  Nd", "", string.Format("  {0:0}", Nd));

            dataGridView3.Rows.Add("  N", "", string.Format("  {0:0}", N));

            dataGridView3.Rows.Add("  P", "", string.Format("  {0:0.0000}", P));

            dataGridView3.Rows.Add("  R", "  ohm", string.Format("  {0:0.0000}", R));

            dataGridView3.Rows.Add("  I", "  Amper", string.Format("  {0:0.0000}", I));

            dataGridView3.Rows.Add("  actual MMF", "  A", string.Format("  {0:0}", actualMMF));

            dataGridView3.Rows.Add("  Wire gauge index", " ", string.Format("  {0:0}", SWGAWGBWGIndex));






            



        }

        private double getDFromFile(string v, double d)
        {
            throw new NotImplementedException();
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
                        iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 25, BaseColor.RED);

                        Paragraph p = new Paragraph();

                        p.Alignment = Element.ALIGN_CENTER;//adjust the alignment of the heading

                        p.Add(new Chunk("Report",   headerFont));//adding a heading to the PDF

                        doc.Add(p);//adding component to the document

                        Paragraph p2 = new Paragraph();

                        p2.Add(new Chunk("                      ", headerFont));//adding a heading to the PDF

                        doc.Add(p2);//adding component to the document

                        iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.BLACK);

                        //creating pdf table
                        PdfPTable table = new PdfPTable(dataGridView3.Columns.Count);

                        for (int j = 0; j < dataGridView3.Columns.Count; j++)

                        {
                            PdfPCell cell = new PdfPCell(); //create object from the pdfpcell

                            cell.BackgroundColor = BaseColor.YELLOW;//set color of cells

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

        private void Exsitationcoil_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            label15.Enabled = false;
            maskedTextBox9.Enabled = false;

            if (checkBox1.Checked)
            {

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;


            }
            else
            {

                maskedTextBox9.Enabled = true;
                label15.Enabled = true;
                if (Double.Parse(textBox1.Text) > 0 && Double.Parse(textBox1.Text) < 100)
                {
                    maskedTextBox9.Text = "0.75";

                }
                else if (Double.Parse(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Invalid value");
                }
                else
                {
                    maskedTextBox9.Text = "0.50";
                }


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox3.SelectedIndex == 0)
            {
                double Q = Double.Parse(maskedTextBox13.Text);
                vc = (v - Q) / p;
                label18.Text = "V";
            }
            else
            {
                double Q = Double.Parse(maskedTextBox13.Text);
                vc = ((1 - Q) * v) / p;
                label18.Text = "%";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox13.Enabled = false;
            label18.Enabled = false;
            comboBox3.Enabled = false;

            if (checkBox3.Checked)
            {
                maskedTextBox13.Enabled = false;
                label18.Enabled = false;
                comboBox3.Enabled = false;
            }
            else
            {
                maskedTextBox13.Enabled = true;
                label18.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        
    }
}