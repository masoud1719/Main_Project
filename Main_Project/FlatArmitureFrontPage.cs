﻿using Main_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FlatArmitureFrontPage : UserControl
    {
        private double mass;
        private double stroke;
        public FlatArmitureFrontPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getValues();
            double indexNumber = Math.Sqrt(mass) / stroke;
            bool isMass = comboBoxForce.SelectedIndex == 0;
            Vahid_MainForm.openForm(indexNumber, Type.FlatArmature, mass, stroke * 100, isMass);
        }

        private void getValues()
        {
            {
                mass = Double.Parse(txtForce.Text);
                if (comboBoxForce.SelectedIndex == 1)
                {
                    mass /= 9.81;
                }

                stroke = Double.Parse(txtStroke.Text);
                stroke *= Math.Pow(10, -2);
            }
        }


        private void comboBoxForce_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxForce.SelectedIndex == 0)
            {
                lblForce.Text = "Kg";
            }
            else
            {
                lblForce.Text = "N";
            }
        }

        private void FlatArmitureFrontPage_Load(object sender, EventArgs e)
        {
            comboBoxForce.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}