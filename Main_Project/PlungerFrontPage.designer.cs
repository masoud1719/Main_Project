using System.Windows.Forms;
namespace Main
{
    partial class PlungerFrontPage
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
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Main_Project.Properties.Resources.plunger_3D_view;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(290, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "cm";
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblForce.Location = new System.Drawing.Point(290, 323);
            this.lblForce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(20, 13);
            this.lblForce.TabIndex = 44;
            this.lblForce.Text = "Kg";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Location = new System.Drawing.Point(128, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 45);
            this.button1.TabIndex = 43;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(109, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Stroke (g)";
            // 
            // txtStroke
            // 
            this.txtStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStroke.Location = new System.Drawing.Point(188, 354);
            this.txtStroke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStroke.Name = "txtStroke";
            this.txtStroke.Size = new System.Drawing.Size(86, 20);
            this.txtStroke.TabIndex = 41;
            // 
            // txtForce
            // 
            this.txtForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtForce.Location = new System.Drawing.Point(188, 322);
            this.txtForce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(86, 20);
            this.txtForce.TabIndex = 40;
            // 
            // comboBoxForce
            // 
            this.comboBoxForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxForce.FormattingEnabled = true;
            this.comboBoxForce.Items.AddRange(new object[] {
            "Mass",
            "Force"});
            this.comboBoxForce.Location = new System.Drawing.Point(80, 320);
            this.comboBoxForce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxForce.Name = "comboBoxForce";
            this.comboBoxForce.Size = new System.Drawing.Size(78, 21);
            this.comboBoxForce.TabIndex = 39;
            // 
            // PlungerFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForce);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStroke);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.comboBoxForce);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlungerFrontPage";
            this.Size = new System.Drawing.Size(785, 484);
            this.Load += new System.EventHandler(this.UserControl1_Load);
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
