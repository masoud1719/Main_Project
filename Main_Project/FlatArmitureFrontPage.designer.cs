using System.Windows.Forms;

namespace Main
{
    partial class FlatArmitureFrontPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForce = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStroke = new System.Windows.Forms.TextBox();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.comboBoxForce = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Main_Project.Properties.Resources.lifting_elctromagnet_on_excavator;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(385, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "cm";
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblForce.Location = new System.Drawing.Point(386, 337);
            this.lblForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(20, 13);
            this.lblForce.TabIndex = 14;
            this.lblForce.Text = "Kg";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Location = new System.Drawing.Point(230, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(218, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stroke (g)";
            // 
            // txtStroke
            // 
            this.txtStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStroke.Location = new System.Drawing.Point(297, 368);
            this.txtStroke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStroke.Name = "txtStroke";
            this.txtStroke.Size = new System.Drawing.Size(71, 20);
            this.txtStroke.TabIndex = 11;
            // 
            // txtForce
            // 
            this.txtForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtForce.Location = new System.Drawing.Point(296, 335);
            this.txtForce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(72, 20);
            this.txtForce.TabIndex = 10;
            // 
            // comboBoxForce
            // 
            this.comboBoxForce.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxForce.FormattingEnabled = true;
            this.comboBoxForce.Items.AddRange(new object[] {
            "Mass",
            "Force"});
            this.comboBoxForce.Location = new System.Drawing.Point(200, 335);
            this.comboBoxForce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxForce.Name = "comboBoxForce";
            this.comboBoxForce.Size = new System.Drawing.Size(67, 21);
            this.comboBoxForce.TabIndex = 9;
            this.comboBoxForce.SelectedIndexChanged += new System.EventHandler(this.comboBoxForce_SelectedIndexChanged_1);
            // 
            // FlatArmitureFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForce);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStroke);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.comboBoxForce);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlatArmitureFrontPage";
            this.Size = new System.Drawing.Size(762, 470);
            this.Load += new System.EventHandler(this.FlatArmitureFrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblForce;
        private Button button1;
        private Label label2;
        private TextBox txtStroke;
        private TextBox txtForce;
        private ComboBox comboBoxForce;
    }
}
