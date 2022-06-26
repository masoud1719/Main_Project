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
            this.label1 = new System.Windows.Forms.Label();
            this.lblForce = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStroke = new System.Windows.Forms.TextBox();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.comboBoxForce = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(341, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "cm";
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblForce.Location = new System.Drawing.Point(341, 404);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(23, 16);
            this.lblForce.TabIndex = 36;
            this.lblForce.Text = "Kg";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Location = new System.Drawing.Point(124, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 55);
            this.button1.TabIndex = 35;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(99, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Stroke (g)";
            // 
            // txtStroke
            // 
            this.txtStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStroke.Location = new System.Drawing.Point(205, 442);
            this.txtStroke.Name = "txtStroke";
            this.txtStroke.Size = new System.Drawing.Size(114, 22);
            this.txtStroke.TabIndex = 33;
            // 
            // txtForce
            // 
            this.txtForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtForce.Location = new System.Drawing.Point(205, 402);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(114, 22);
            this.txtForce.TabIndex = 32;
            // 
            // comboBoxForce
            // 
            this.comboBoxForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxForce.FormattingEnabled = true;
            this.comboBoxForce.Items.AddRange(new object[] {
            "Mass",
            "Force"});
            this.comboBoxForce.Location = new System.Drawing.Point(61, 400);
            this.comboBoxForce.Name = "comboBoxForce";
            this.comboBoxForce.Size = new System.Drawing.Size(103, 24);
            this.comboBoxForce.TabIndex = 31;

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::Main_Project.Properties.Resources.plunger_3D_view;
            this.pictureBox1.Location = new System.Drawing.Point(402, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PlungerFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Name = "PlungerFrontPage";
            this.Size = new System.Drawing.Size(949, 599);
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
