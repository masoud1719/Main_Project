using System.Windows.Forms;
namespace Main
{
    partial class HorseShoeFrontPage
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
            this.HorseShoe_c = new System.Windows.Forms.Button();
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(436, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "cm";
            // 
            // lblForce
            // 
            this.lblForce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForce.AutoSize = true;
            this.lblForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblForce.Location = new System.Drawing.Point(436, 451);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(23, 16);
            this.lblForce.TabIndex = 22;
            this.lblForce.Text = "Kg";
            // 
            // HorseShoe_c
            // 
            this.HorseShoe_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HorseShoe_c.BackColor = System.Drawing.Color.DarkSalmon;
            this.HorseShoe_c.Location = new System.Drawing.Point(219, 532);
            this.HorseShoe_c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HorseShoe_c.Name = "HorseShoe_c";
            this.HorseShoe_c.Size = new System.Drawing.Size(140, 55);
            this.HorseShoe_c.TabIndex = 21;
            this.HorseShoe_c.Text = "Calculate";
            this.HorseShoe_c.UseVisualStyleBackColor = false;
            this.HorseShoe_c.Click += new System.EventHandler(this.HorseShoe_c_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(194, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stroke (g)";
            // 
            // txtStroke
            // 
            this.txtStroke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStroke.Location = new System.Drawing.Point(300, 489);
            this.txtStroke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStroke.Name = "txtStroke";
            this.txtStroke.Size = new System.Drawing.Size(113, 22);
            this.txtStroke.TabIndex = 19;
            // 
            // txtForce
            // 
            this.txtForce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtForce.Location = new System.Drawing.Point(300, 449);
            this.txtForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(113, 22);
            this.txtForce.TabIndex = 18;
            // 
            // comboBoxForce
            // 
            this.comboBoxForce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxForce.FormattingEnabled = true;
            this.comboBoxForce.Items.AddRange(new object[] {
            "Mass",
            "Force"});
            this.comboBoxForce.Location = new System.Drawing.Point(156, 447);
            this.comboBoxForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxForce.Name = "comboBoxForce";
            this.comboBoxForce.Size = new System.Drawing.Size(103, 24);
            this.comboBoxForce.TabIndex = 17;
            this.comboBoxForce.SelectedIndexChanged += new System.EventHandler(this.comboBoxForce_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Main_Project.Properties.Resources.horse_she;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1339, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HorseShoeFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForce);
            this.Controls.Add(this.HorseShoe_c);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStroke);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.comboBoxForce);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HorseShoeFrontPage";
            this.Size = new System.Drawing.Size(1339, 672);
            this.Load += new System.EventHandler(this.HorseShoeFrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblForce;
        private Button HorseShoe_c;
        private Label label2;
        private TextBox txtStroke;
        private TextBox txtForce;
        private ComboBox comboBoxForce;
    }
}
