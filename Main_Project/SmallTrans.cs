using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{

    


    













    public partial class SmallTrans : Form
    {
        public SmallTrans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_ratingvalue.Text != null)
            {
                if (Double.Parse(txt_ratingvalue.Text) <= 0.005)
                {

                    maskvoltreg.Text = "20";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.005 && Double.Parse(txt_ratingvalue.Text) <= 0.010)
                {

                    maskvoltreg.Text = "17";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.010 && Double.Parse(txt_ratingvalue.Text) <= 0.025)
                {

                    maskvoltreg.Text = "15";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.025 && Double.Parse(txt_ratingvalue.Text) <= 0.050)
                {

                    maskvoltreg.Text = "12";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.050 && Double.Parse(txt_ratingvalue.Text) <= 0.075)
                {

                    maskvoltreg.Text = "10";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.075 && Double.Parse(txt_ratingvalue.Text) <= 0.1)
                {

                    maskvoltreg.Text = "9";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.1 && Double.Parse(txt_ratingvalue.Text) <= 0.150)
                {

                    maskvoltreg.Text = "8"; ;
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.150 && Double.Parse(txt_ratingvalue.Text) <= 0.2)
                {

                    maskvoltreg.Text = "7.5";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.200 && Double.Parse(txt_ratingvalue.Text) <= 0.300)
                {

                    maskvoltreg.Text = "7";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.300 && Double.Parse(txt_ratingvalue.Text) <= 0.400)
                {

                    maskvoltreg.Text = "6.5";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.400 && Double.Parse(txt_ratingvalue.Text) <= 0.500)
                {

                    maskvoltreg.Text = "6";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.500 && Double.Parse(txt_ratingvalue.Text) <= 0.750)
                {

                    maskvoltreg.Text = "5";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 0.750 && Double.Parse(txt_ratingvalue.Text) <= 1)
                {

                    maskvoltreg.Text = "4";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 1 && Double.Parse(txt_ratingvalue.Text) <= 1.5)
                {

                    maskvoltreg.Text = "3";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 1.5 && Double.Parse(txt_ratingvalue.Text) <= 2)
                {

                    maskvoltreg.Text = "2";
                }
                else if (Double.Parse(txt_ratingvalue.Text) > 2.0 && Double.Parse(txt_ratingvalue.Text) <= 3.0)
                {

                    maskvoltreg.Text = "1.5";
                }
                else
                {

                    maskvoltreg.Text = "1.5";
                }
            }


            if (Double.Parse(txt_ratingvalue.Text) <= 0.03)
            {
                maskEff.Text = "86.4";
                //txtVoltageRegulation.Text = "20";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.03 && Double.Parse(txt_ratingvalue.Text) <= 0.05)
            {
                maskEff.Text = "87.6";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.05 && Double.Parse(txt_ratingvalue.Text) <= 0.1)
            {
                maskEff.Text = "89.6";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.1 &&  Double.Parse(txt_ratingvalue.Text) <= 0.150)
            {
                maskEff.Text = "90.9";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.150 && Double.Parse(txt_ratingvalue.Text) <= 0.200)
            {
                maskEff.Text = "91.3";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.200 && Double.Parse(txt_ratingvalue.Text) <= 0.300)
            {
                maskEff.Text = "92.3";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.300 && Double.Parse(txt_ratingvalue.Text) <= 0.500)
            {
                maskEff.Text = "93";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.500 && Double.Parse(txt_ratingvalue.Text) <= 0.750)
            {
                maskEff.Text = "93.5";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.750 && Double.Parse(txt_ratingvalue.Text) <= 1)
            {
                maskEff.Text = "94";
                //txtVoltageRegulation.Text = "17";
            }
            else
            {
                maskEff.Text = "94";
                //txtVoltageRegulation.Text = "17";
            }







            if (Double.Parse(txt_ratingvalue.Text) <= 0.05)
            {
                maskedCurrent.Text = "4.0";
                //txtVoltageRegulation.Text = "20";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.05 && Double.Parse(txt_ratingvalue.Text) <= 0.1)
            {
                maskedCurrent.Text = "3.5";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.1 && Double.Parse(txt_ratingvalue.Text) <= 0.2)
            {
                maskedCurrent.Text = "3.0";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.2 && Double.Parse(txt_ratingvalue.Text) <= 0.5)
            {
                maskedCurrent.Text = "2.5";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.5 && Double.Parse(txt_ratingvalue.Text) <= 1.0)
            {
                maskedCurrent.Text = "2.0";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 1.0 && Double.Parse(txt_ratingvalue.Text) <= 2.0)
            {
                maskedCurrent.Text = "1.75";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 2.0 && Double.Parse(txt_ratingvalue.Text) <= 3.0)
            {
                maskedCurrent.Text = "1.5";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 3.0 && Double.Parse(txt_ratingvalue.Text) <= 4.0)
            {
                maskedCurrent.Text = "1.0";
                //txtVoltageRegulation.Text = "17";
            }
            else
            {
                maskedCurrent.Text = "0.8";
                //txtVoltageRegulation.Text = "17";
            }







            if (Double.Parse(txt_ratingvalue.Text) <= 0.2)
            {
                maskedk.Text = "0.8";
                //txtVoltageRegulation.Text = "20";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.2 && Double.Parse(txt_ratingvalue.Text) <= 0.5)
            {
                maskedk.Text = "0.9";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 0.5 && Double.Parse(txt_ratingvalue.Text) <= 1.0)
            {
                maskedk.Text = "1.0";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 1.0 && Double.Parse(txt_ratingvalue.Text) <= 2.0)
            {
                maskedk.Text = "1.1";
                //txtVoltageRegulation.Text = "17";
            }
            else if (Double.Parse(txt_ratingvalue.Text) > 2.0 && Double.Parse(txt_ratingvalue.Text) <= 4.0)
            {
                maskedk.Text = "1.2";
                //txtVoltageRegulation.Text = "17";
            }
            else
            {
                maskedk.Text = "1.25";
                //txtVoltageRegulation.Text = "17";
            }








            








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

        private void combo_Steel_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            else if (combo_Steel.Text == "M36")
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
                if (txt_Frequency.Text == "50")
                {

                    txt_Wi.Text = "1.475";
                }
                else
                {
                    
                    txt_Wi.Text = "1.6";
                }
                
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





















    }
}
