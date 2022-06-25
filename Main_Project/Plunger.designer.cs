using System.Windows.Forms;
namespace testmna
{
    partial class Plunger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_force = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmbientTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.txtStroke = new System.Windows.Forms.TextBox();
            this.txtVolyage = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.TextBox();
            this.txtAmbientTemp = new System.Windows.Forms.TextBox();
            this.method1 = new System.Windows.Forms.RadioButton();
            this.method2 = new System.Windows.Forms.RadioButton();
            this.lbl_force = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_wire = new System.Windows.Forms.ComboBox();
            this.txt_permeability = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_accuracy = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbConsiderLimit = new System.Windows.Forms.RadioButton();
            this.rdbuseDefaultValue = new System.Windows.Forms.RadioButton();
            this.rdbfixTheFactor = new System.Windows.Forms.RadioButton();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtslotSpaceFactor = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbldc = new System.Windows.Forms.Label();
            this.lblPicH = new System.Windows.Forms.Label();
            this.lblPicT4 = new System.Windows.Forms.Label();
            this.lblPicT2 = new System.Windows.Forms.Label();
            this.lblPicStroke = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.lblPicN2 = new System.Windows.Forms.Label();
            this.lblPicT3 = new System.Windows.Forms.Label();
            this.lblPicr3 = new System.Windows.Forms.Label();
            this.lblPicr2 = new System.Windows.Forms.Label();
            this.lblPicr1 = new System.Windows.Forms.Label();
            this.lblPicT1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtHeightToDepthRatio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_allowance_fibr = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.txt_allowance_mica = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.txt_allowance_irr = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_outside = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_brass = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_plunger = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_thickness = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_Intermittentraiting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inferior = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txt_leakage = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.text_Maxiteration = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_force
            // 
            this.cmb_force.FormattingEnabled = true;
            this.cmb_force.Items.AddRange(new object[] {
            "Force",
            "Mass"});
            this.cmb_force.Location = new System.Drawing.Point(15, 20);
            this.cmb_force.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_force.Name = "cmb_force";
            this.cmb_force.Size = new System.Drawing.Size(89, 24);
            this.cmb_force.TabIndex = 0;
            this.cmb_force.Text = "Mass";
            this.cmb_force.SelectedValueChanged += new System.EventHandler(this.cmb_force_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stroke (g)";
            this.toolTip1.SetToolTip(this.label1, "my exp about stroke");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voltage (V)";
            this.toolTip1.SetToolTip(this.label2, "my explanation about voltage");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempreature rise (Tm)";
            this.toolTip1.SetToolTip(this.label3, "salam khobi?");
            // 
            // AmbientTemperature
            // 
            this.AmbientTemperature.AutoSize = true;
            this.AmbientTemperature.Location = new System.Drawing.Point(12, 172);
            this.AmbientTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmbientTemperature.Name = "AmbientTemperature";
            this.AmbientTemperature.Size = new System.Drawing.Size(165, 16);
            this.AmbientTemperature.TabIndex = 4;
            this.AmbientTemperature.Text = "Ambient Temperature (Ta)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "MMF Calculation method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = ":";
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(253, 20);
            this.txtForce.Margin = new System.Windows.Forms.Padding(4);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(81, 22);
            this.txtForce.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtForce, "test");
            // 
            // txtStroke
            // 
            this.txtStroke.Location = new System.Drawing.Point(254, 58);
            this.txtStroke.Margin = new System.Windows.Forms.Padding(4);
            this.txtStroke.Name = "txtStroke";
            this.txtStroke.Size = new System.Drawing.Size(80, 22);
            this.txtStroke.TabIndex = 13;
            // 
            // txtVolyage
            // 
            this.txtVolyage.Location = new System.Drawing.Point(254, 94);
            this.txtVolyage.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolyage.Name = "txtVolyage";
            this.txtVolyage.Size = new System.Drawing.Size(80, 22);
            this.txtVolyage.TabIndex = 14;
            // 
            // Temperature
            // 
            this.Temperature.Location = new System.Drawing.Point(254, 134);
            this.Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(80, 22);
            this.Temperature.TabIndex = 15;
            this.Temperature.Text = "75";
            // 
            // txtAmbientTemp
            // 
            this.txtAmbientTemp.Location = new System.Drawing.Point(254, 170);
            this.txtAmbientTemp.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmbientTemp.Name = "txtAmbientTemp";
            this.txtAmbientTemp.Size = new System.Drawing.Size(80, 22);
            this.txtAmbientTemp.TabIndex = 16;
            this.txtAmbientTemp.Text = "40";
            // 
            // method1
            // 
            this.method1.AutoSize = true;
            this.method1.Checked = true;
            this.method1.Location = new System.Drawing.Point(16, 242);
            this.method1.Margin = new System.Windows.Forms.Padding(4);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(80, 20);
            this.method1.TabIndex = 17;
            this.method1.TabStop = true;
            this.method1.Text = "Method1";
            this.method1.UseVisualStyleBackColor = true;
            // 
            // method2
            // 
            this.method2.AutoSize = true;
            this.method2.Location = new System.Drawing.Point(162, 242);
            this.method2.Margin = new System.Windows.Forms.Padding(4);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(80, 20);
            this.method2.TabIndex = 18;
            this.method2.Text = "Method2";
            this.method2.UseVisualStyleBackColor = true;
            // 
            // lbl_force
            // 
            this.lbl_force.AutoSize = true;
            this.lbl_force.Location = new System.Drawing.Point(352, 19);
            this.lbl_force.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_force.Name = "lbl_force";
            this.lbl_force.Size = new System.Drawing.Size(22, 16);
            this.lbl_force.TabIndex = 20;
            this.lbl_force.Text = "kg";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(349, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "cm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 96);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "V";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 138);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "°C";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 172);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "°C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(15, 279);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Permeability";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 353);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "Inferior";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 316);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 16);
            this.label19.TabIndex = 27;
            this.label19.Text = "Intermittent raiting (q)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 465);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(206, 16);
            this.label20.TabIndex = 28;
            this.label20.Text = "Height to depth ratio ( h / ( r2 - r1 ) )";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(271, 280);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(271, 314);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 16);
            this.label22.TabIndex = 30;
            this.label22.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(271, 424);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 16);
            this.label23.TabIndex = 31;
            this.label23.Text = ":";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(271, 463);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(10, 16);
            this.label24.TabIndex = 32;
            this.label24.Text = ":";
            // 
            // txt_wire
            // 
            this.txt_wire.FormattingEnabled = true;
            this.txt_wire.Items.AddRange(new object[] {
            "SWG",
            "AWG",
            "BWG"});
            this.txt_wire.Location = new System.Drawing.Point(298, 421);
            this.txt_wire.Margin = new System.Windows.Forms.Padding(4);
            this.txt_wire.Name = "txt_wire";
            this.txt_wire.Size = new System.Drawing.Size(79, 24);
            this.txt_wire.TabIndex = 34;
            // 
            // txt_permeability
            // 
            this.txt_permeability.Enabled = false;
            this.txt_permeability.Location = new System.Drawing.Point(297, 278);
            this.txt_permeability.Margin = new System.Windows.Forms.Padding(4);
            this.txt_permeability.Name = "txt_permeability";
            this.txt_permeability.Size = new System.Drawing.Size(80, 22);
            this.txt_permeability.TabIndex = 35;
            this.txt_permeability.Text = "2000";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(460, 416);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 16);
            this.label27.TabIndex = 38;
            this.label27.Text = "Accuracy";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(458, 464);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(114, 16);
            this.label28.TabIndex = 39;
            this.label28.Text = "Maximum iteration";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(634, 416);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(10, 16);
            this.label31.TabIndex = 42;
            this.label31.Text = ":";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(634, 464);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(10, 16);
            this.label32.TabIndex = 43;
            this.label32.Text = ":";
            // 
            // txt_accuracy
            // 
            this.txt_accuracy.Location = new System.Drawing.Point(680, 416);
            this.txt_accuracy.Margin = new System.Windows.Forms.Padding(4);
            this.txt_accuracy.Name = "txt_accuracy";
            this.txt_accuracy.Size = new System.Drawing.Size(93, 22);
            this.txt_accuracy.TabIndex = 46;
            this.txt_accuracy.Text = "5";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(816, 425);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(19, 16);
            this.label53.TabIndex = 73;
            this.label53.Text = "%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbConsiderLimit);
            this.groupBox2.Controls.Add(this.rdbuseDefaultValue);
            this.groupBox2.Controls.Add(this.rdbfixTheFactor);
            this.groupBox2.Location = new System.Drawing.Point(214, 548);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(535, 39);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            // 
            // rdbConsiderLimit
            // 
            this.rdbConsiderLimit.AutoSize = true;
            this.rdbConsiderLimit.Location = new System.Drawing.Point(373, -19);
            this.rdbConsiderLimit.Margin = new System.Windows.Forms.Padding(4);
            this.rdbConsiderLimit.Name = "rdbConsiderLimit";
            this.rdbConsiderLimit.Size = new System.Drawing.Size(119, 20);
            this.rdbConsiderLimit.TabIndex = 77;
            this.rdbConsiderLimit.Text = "Consider Limits";
            this.rdbConsiderLimit.UseVisualStyleBackColor = true;
            // 
            // rdbuseDefaultValue
            // 
            this.rdbuseDefaultValue.AutoSize = true;
            this.rdbuseDefaultValue.Checked = true;
            this.rdbuseDefaultValue.Location = new System.Drawing.Point(188, -19);
            this.rdbuseDefaultValue.Margin = new System.Windows.Forms.Padding(4);
            this.rdbuseDefaultValue.Name = "rdbuseDefaultValue";
            this.rdbuseDefaultValue.Size = new System.Drawing.Size(129, 20);
            this.rdbuseDefaultValue.TabIndex = 76;
            this.rdbuseDefaultValue.TabStop = true;
            this.rdbuseDefaultValue.Text = "use default value";
            this.rdbuseDefaultValue.UseVisualStyleBackColor = true;
            // 
            // rdbfixTheFactor
            // 
            this.rdbfixTheFactor.AutoSize = true;
            this.rdbfixTheFactor.Location = new System.Drawing.Point(32, -19);
            this.rdbfixTheFactor.Margin = new System.Windows.Forms.Padding(4);
            this.rdbfixTheFactor.Name = "rdbfixTheFactor";
            this.rdbfixTheFactor.Size = new System.Drawing.Size(102, 20);
            this.rdbfixTheFactor.TabIndex = 75;
            this.rdbfixTheFactor.Text = "Fix the factor";
            this.rdbfixTheFactor.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(17, 632);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(144, 16);
            this.label54.TabIndex = 75;
            this.label54.Text = "Slot space factor (SSF)";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(241, 632);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(10, 16);
            this.label55.TabIndex = 76;
            this.label55.Text = ":";
            // 
            // txtslotSpaceFactor
            // 
            this.txtslotSpaceFactor.Location = new System.Drawing.Point(285, 628);
            this.txtslotSpaceFactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtslotSpaceFactor.Name = "txtslotSpaceFactor";
            this.txtslotSpaceFactor.Size = new System.Drawing.Size(132, 22);
            this.txtslotSpaceFactor.TabIndex = 77;
            this.txtslotSpaceFactor.Text = "0.7";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(887, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 528);
            this.tabControl1.TabIndex = 79;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbldc);
            this.tabPage1.Controls.Add(this.lblPicH);
            this.tabPage1.Controls.Add(this.lblPicT4);
            this.tabPage1.Controls.Add(this.lblPicT2);
            this.tabPage1.Controls.Add(this.lblPicStroke);
            this.tabPage1.Controls.Add(this.label61);
            this.tabPage1.Controls.Add(this.lblPicN2);
            this.tabPage1.Controls.Add(this.lblPicT3);
            this.tabPage1.Controls.Add(this.lblPicr3);
            this.tabPage1.Controls.Add(this.lblPicr2);
            this.tabPage1.Controls.Add(this.lblPicr1);
            this.tabPage1.Controls.Add(this.lblPicT1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(659, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbldc
            // 
            this.lbldc.AutoSize = true;
            this.lbldc.Location = new System.Drawing.Point(387, 163);
            this.lbldc.Name = "lbldc";
            this.lbldc.Size = new System.Drawing.Size(21, 16);
            this.lbldc.TabIndex = 114;
            this.lbldc.Text = "=0";
            // 
            // lblPicH
            // 
            this.lblPicH.AutoSize = true;
            this.lblPicH.Location = new System.Drawing.Point(332, 445);
            this.lblPicH.Name = "lblPicH";
            this.lblPicH.Size = new System.Drawing.Size(21, 16);
            this.lblPicH.TabIndex = 113;
            this.lblPicH.Text = "=0";
            // 
            // lblPicT4
            // 
            this.lblPicT4.AutoSize = true;
            this.lblPicT4.Location = new System.Drawing.Point(504, 49);
            this.lblPicT4.Name = "lblPicT4";
            this.lblPicT4.Size = new System.Drawing.Size(21, 16);
            this.lblPicT4.TabIndex = 112;
            this.lblPicT4.Text = "=0";
            // 
            // lblPicT2
            // 
            this.lblPicT2.AutoSize = true;
            this.lblPicT2.Location = new System.Drawing.Point(491, 75);
            this.lblPicT2.Name = "lblPicT2";
            this.lblPicT2.Size = new System.Drawing.Size(21, 16);
            this.lblPicT2.TabIndex = 111;
            this.lblPicT2.Text = "=0";
            // 
            // lblPicStroke
            // 
            this.lblPicStroke.AutoSize = true;
            this.lblPicStroke.Location = new System.Drawing.Point(591, 219);
            this.lblPicStroke.Name = "lblPicStroke";
            this.lblPicStroke.Size = new System.Drawing.Size(21, 16);
            this.lblPicStroke.TabIndex = 110;
            this.lblPicStroke.Text = "=0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(312, 238);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(21, 16);
            this.label61.TabIndex = 109;
            this.label61.Text = "=0";
            // 
            // lblPicN2
            // 
            this.lblPicN2.AutoSize = true;
            this.lblPicN2.Location = new System.Drawing.Point(43, 279);
            this.lblPicN2.Name = "lblPicN2";
            this.lblPicN2.Size = new System.Drawing.Size(21, 16);
            this.lblPicN2.TabIndex = 108;
            this.lblPicN2.Text = "=0";
            // 
            // lblPicT3
            // 
            this.lblPicT3.AutoSize = true;
            this.lblPicT3.Location = new System.Drawing.Point(491, 187);
            this.lblPicT3.Name = "lblPicT3";
            this.lblPicT3.Size = new System.Drawing.Size(21, 16);
            this.lblPicT3.TabIndex = 103;
            this.lblPicT3.Text = "=0";
            // 
            // lblPicr3
            // 
            this.lblPicr3.AutoSize = true;
            this.lblPicr3.Location = new System.Drawing.Point(254, 238);
            this.lblPicr3.Name = "lblPicr3";
            this.lblPicr3.Size = new System.Drawing.Size(21, 16);
            this.lblPicr3.TabIndex = 100;
            this.lblPicr3.Text = "=0";
            // 
            // lblPicr2
            // 
            this.lblPicr2.AutoSize = true;
            this.lblPicr2.Location = new System.Drawing.Point(201, 238);
            this.lblPicr2.Name = "lblPicr2";
            this.lblPicr2.Size = new System.Drawing.Size(21, 16);
            this.lblPicr2.TabIndex = 99;
            this.lblPicr2.Text = "=0";
            // 
            // lblPicr1
            // 
            this.lblPicr1.AutoSize = true;
            this.lblPicr1.Location = new System.Drawing.Point(147, 238);
            this.lblPicr1.Name = "lblPicr1";
            this.lblPicr1.Size = new System.Drawing.Size(21, 16);
            this.lblPicr1.TabIndex = 98;
            this.lblPicr1.Text = "=0";
            // 
            // lblPicT1
            // 
            this.lblPicT1.AutoSize = true;
            this.lblPicT1.Location = new System.Drawing.Point(69, 213);
            this.lblPicT1.Name = "lblPicT1";
            this.lblPicT1.Size = new System.Drawing.Size(21, 16);
            this.lblPicT1.TabIndex = 97;
            this.lblPicT1.Text = "=0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(659, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(651, 491);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(656, 499);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(659, 499);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(656, 499);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(974, 570);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(241, 78);
            this.btncalc.TabIndex = 80;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1253, 570);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(241, 78);
            this.btnExport.TabIndex = 81;
            this.btnExport.Text = "Export as PDF";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Location = new System.Drawing.Point(244, 652);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(577, 62);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MMF Calculation formula";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(30, 20);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(137, 16);
            this.label56.TabIndex = 83;
            this.label56.Text = "Total radius insulation";
            // 
            // txtHeightToDepthRatio
            // 
            this.txtHeightToDepthRatio.Location = new System.Drawing.Point(297, 461);
            this.txtHeightToDepthRatio.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeightToDepthRatio.Name = "txtHeightToDepthRatio";
            this.txtHeightToDepthRatio.Size = new System.Drawing.Size(80, 22);
            this.txtHeightToDepthRatio.TabIndex = 85;
            this.txtHeightToDepthRatio.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txt_allowance_fibr);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.txt_allowance_mica);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.txt_allowance_irr);
            this.groupBox1.Controls.Add(this.label57);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.txt_outside);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.txt_brass);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.txt_plunger);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.txt_thickness);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Location = new System.Drawing.Point(449, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(377, 276);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insulation";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(334, 246);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 16);
            this.label25.TabIndex = 121;
            this.label25.Text = "mm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(229, 246);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(10, 16);
            this.label26.TabIndex = 119;
            this.label26.Text = ":";
            // 
            // txt_allowance_fibr
            // 
            this.txt_allowance_fibr.Location = new System.Drawing.Point(257, 244);
            this.txt_allowance_fibr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allowance_fibr.Name = "txt_allowance_fibr";
            this.txt_allowance_fibr.Size = new System.Drawing.Size(67, 22);
            this.txt_allowance_fibr.TabIndex = 120;
            this.txt_allowance_fibr.Text = "0.75";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 246);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(192, 16);
            this.label29.TabIndex = 118;
            this.label29.Text = "Allowance for fibre at both ends";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(334, 214);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(29, 16);
            this.label58.TabIndex = 117;
            this.label58.Text = "mm";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(229, 213);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(10, 16);
            this.label59.TabIndex = 115;
            this.label59.Text = ":";
            // 
            // txt_allowance_mica
            // 
            this.txt_allowance_mica.Location = new System.Drawing.Point(257, 211);
            this.txt_allowance_mica.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allowance_mica.Name = "txt_allowance_mica";
            this.txt_allowance_mica.Size = new System.Drawing.Size(67, 22);
            this.txt_allowance_mica.TabIndex = 116;
            this.txt_allowance_mica.Text = "0.5";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 214);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(119, 16);
            this.label60.TabIndex = 114;
            this.label60.Text = "Allowance for mica";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(334, 180);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(29, 16);
            this.label49.TabIndex = 113;
            this.label49.Text = "mm";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(229, 179);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(10, 16);
            this.label50.TabIndex = 111;
            this.label50.Text = ":";
            // 
            // txt_allowance_irr
            // 
            this.txt_allowance_irr.Location = new System.Drawing.Point(257, 178);
            this.txt_allowance_irr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allowance_irr.Name = "txt_allowance_irr";
            this.txt_allowance_irr.Size = new System.Drawing.Size(67, 22);
            this.txt_allowance_irr.TabIndex = 112;
            this.txt_allowance_irr.Text = "0.4";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(8, 180);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(160, 16);
            this.label57.TabIndex = 110;
            this.label57.Text = "Albwance for irregularities";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(334, 145);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 16);
            this.label46.TabIndex = 109;
            this.label46.Text = "mm";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(229, 144);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(10, 16);
            this.label47.TabIndex = 107;
            this.label47.Text = ":";
            // 
            // txt_outside
            // 
            this.txt_outside.Location = new System.Drawing.Point(257, 142);
            this.txt_outside.Margin = new System.Windows.Forms.Padding(4);
            this.txt_outside.Name = "txt_outside";
            this.txt_outside.Size = new System.Drawing.Size(67, 22);
            this.txt_outside.TabIndex = 108;
            this.txt_outside.Text = "0.6";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 145);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(157, 16);
            this.label48.TabIndex = 106;
            this.label48.Text = "Outside the coil insulation";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(334, 110);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 16);
            this.label43.TabIndex = 105;
            this.label43.Text = "mm";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(229, 110);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(10, 16);
            this.label44.TabIndex = 103;
            this.label44.Text = ":";
            // 
            // txt_brass
            // 
            this.txt_brass.Location = new System.Drawing.Point(257, 108);
            this.txt_brass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_brass.Name = "txt_brass";
            this.txt_brass.Size = new System.Drawing.Size(67, 22);
            this.txt_brass.TabIndex = 104;
            this.txt_brass.Text = "0.4";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(8, 110);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(158, 16);
            this.label45.TabIndex = 102;
            this.label45.Text = "Brass tube_coil insulation";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(334, 75);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(29, 16);
            this.label42.TabIndex = 101;
            this.label42.Text = "mm";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(334, 40);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 16);
            this.label41.TabIndex = 96;
            this.label41.Text = "mm";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(229, 74);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(10, 16);
            this.label40.TabIndex = 99;
            this.label40.Text = ":";
            // 
            // txt_plunger
            // 
            this.txt_plunger.Location = new System.Drawing.Point(257, 73);
            this.txt_plunger.Margin = new System.Windows.Forms.Padding(4);
            this.txt_plunger.Name = "txt_plunger";
            this.txt_plunger.Size = new System.Drawing.Size(67, 22);
            this.txt_plunger.TabIndex = 100;
            this.txt_plunger.Text = "0.05";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(229, 40);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(10, 16);
            this.label39.TabIndex = 96;
            this.label39.Text = ":";
            // 
            // txt_thickness
            // 
            this.txt_thickness.Location = new System.Drawing.Point(257, 38);
            this.txt_thickness.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thickness.Name = "txt_thickness";
            this.txt_thickness.Size = new System.Drawing.Size(67, 22);
            this.txt_thickness.TabIndex = 98;
            this.txt_thickness.Text = "0.5";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(8, 75);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(185, 16);
            this.label38.TabIndex = 97;
            this.label38.Text = "plunger_brass tube clearance";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(8, 40);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(149, 16);
            this.label35.TabIndex = 96;
            this.label35.Text = "Thickness of brass tube";
            // 
            // txt_Intermittentraiting
            // 
            this.txt_Intermittentraiting.Location = new System.Drawing.Point(297, 313);
            this.txt_Intermittentraiting.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Intermittentraiting.Name = "txt_Intermittentraiting";
            this.txt_Intermittentraiting.Size = new System.Drawing.Size(80, 22);
            this.txt_Intermittentraiting.TabIndex = 88;
            this.txt_Intermittentraiting.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Wire gauge";
            // 
            // txt_inferior
            // 
            this.txt_inferior.Location = new System.Drawing.Point(297, 352);
            this.txt_inferior.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inferior.Name = "txt_inferior";
            this.txt_inferior.Size = new System.Drawing.Size(80, 22);
            this.txt_inferior.TabIndex = 90;
            this.txt_inferior.Text = "125";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(271, 353);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(10, 16);
            this.label33.TabIndex = 91;
            this.label33.Text = ":";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(385, 355);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 16);
            this.label34.TabIndex = 92;
            this.label34.Text = "%";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(271, 388);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(10, 16);
            this.label36.TabIndex = 95;
            this.label36.Text = ":";
            // 
            // txt_leakage
            // 
            this.txt_leakage.Location = new System.Drawing.Point(297, 387);
            this.txt_leakage.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leakage.Name = "txt_leakage";
            this.txt_leakage.Size = new System.Drawing.Size(80, 22);
            this.txt_leakage.TabIndex = 94;
            this.txt_leakage.Text = "1.45";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 388);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(97, 16);
            this.label37.TabIndex = 93;
            this.label37.Text = "Leakage factor";
            // 
            // text_Maxiteration
            // 
            this.text_Maxiteration.Location = new System.Drawing.Point(680, 465);
            this.text_Maxiteration.Margin = new System.Windows.Forms.Padding(4);
            this.text_Maxiteration.Name = "text_Maxiteration";
            this.text_Maxiteration.Size = new System.Drawing.Size(80, 22);
            this.text_Maxiteration.TabIndex = 96;
            this.text_Maxiteration.Text = "30";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parameter,
            this.unit,
            this.value});
            this.dataGridView3.Location = new System.Drawing.Point(739, 672);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(815, 142);
            this.dataGridView3.TabIndex = 167;
            // 
            // Parameter
            // 
            this.Parameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Parameter.DefaultCellStyle = dataGridViewCellStyle1;
            this.Parameter.HeaderText = "                  Parameter";
            this.Parameter.MinimumWidth = 6;
            this.Parameter.Name = "Parameter";
            this.Parameter.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.unit.DefaultCellStyle = dataGridViewCellStyle2;
            this.unit.HeaderText = "                     unit";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.value.DefaultCellStyle = dataGridViewCellStyle3;
            this.value.HeaderText = "                      value";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Main_Project.Properties.Resources.Screenshot__568_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Plunger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1588, 844);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.text_Maxiteration);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.txt_leakage);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txt_inferior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Intermittentraiting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHeightToDepthRatio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtslotSpaceFactor);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.txt_accuracy);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txt_permeability);
            this.Controls.Add(this.txt_wire);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_force);
            this.Controls.Add(this.method2);
            this.Controls.Add(this.method1);
            this.Controls.Add(this.txtAmbientTemp);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.txtVolyage);
            this.Controls.Add(this.txtStroke);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmbientTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_force);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plunger";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_force;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AmbientTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.TextBox txtStroke;
        private System.Windows.Forms.TextBox txtVolyage;
        private System.Windows.Forms.TextBox Temperature;
        private System.Windows.Forms.TextBox txtAmbientTemp;
        private System.Windows.Forms.RadioButton method1;
        private System.Windows.Forms.RadioButton method2;
        private System.Windows.Forms.Label lbl_force;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox txt_wire;
        private System.Windows.Forms.TextBox txt_permeability;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txt_accuracy;
        private System.Windows.Forms.TextBox maximumIteration;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbConsiderLimit;
        private System.Windows.Forms.RadioButton rdbuseDefaultValue;
        private System.Windows.Forms.RadioButton rdbfixTheFactor;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtslotSpaceFactor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox txtHeightToDepthRatio;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBox txt_Intermittentraiting;
        private Label label4;
        private TextBox txt_inferior;
        private Label label33;
        private Label label34;
        private Label label36;
        private TextBox txt_leakage;
        private Label label37;
        private Label label38;
        private Label label35;
        private Label label40;
        private TextBox txt_plunger;
        private Label label39;
        private TextBox txt_thickness;
        private Label label58;
        private Label label59;
        private TextBox txt_allowance_mica;
        private Label label60;
        private Label label49;
        private Label label50;
        private TextBox txt_allowance_irr;
        private Label label57;
        private Label label46;
        private Label label47;
        private TextBox txt_outside;
        private Label label48;
        private Label label43;
        private Label label44;
        private TextBox txt_brass;
        private Label label45;
        private Label label42;
        private Label label41;
        private Label label25;
        private Label label26;
        private TextBox txt_allowance_fibr;
        private Label label29;
        private ToolTip toolTip1;
        private TextBox text_Maxiteration;
        private PictureBox pictureBox1;
        private Label lblPicT1;
        private Label lblPicH;
        private Label lblPicT4;
        private Label lblPicT2;
        private Label lblPicStroke;
        private Label label61;
        private Label lblPicN2;
        private Label lblPicT3;
        private Label lblPicr3;
        private Label lblPicr2;
        private Label lblPicr1;
        private Label lbldc;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Parameter;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn value;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

