namespace _02_TimerControl
{
    partial class arabaYarisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arabaYarisi));
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbİkinciAraba = new System.Windows.Forms.PictureBox();
            this.pbUcuncuAraba = new System.Windows.Forms.PictureBox();
            this.pbBirinciAraba = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBahis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnbahis = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbİkinciAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUcuncuAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirinciAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "başla";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(598, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 457);
            this.label4.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(17, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Yeniden Oyna";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbİkinciAraba
            // 
            this.pbİkinciAraba.Image = ((System.Drawing.Image)(resources.GetObject("pbİkinciAraba.Image")));
            this.pbİkinciAraba.Location = new System.Drawing.Point(353, 412);
            this.pbİkinciAraba.Name = "pbİkinciAraba";
            this.pbİkinciAraba.Size = new System.Drawing.Size(55, 79);
            this.pbİkinciAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbİkinciAraba.TabIndex = 3;
            this.pbİkinciAraba.TabStop = false;
            // 
            // pbUcuncuAraba
            // 
            this.pbUcuncuAraba.Image = ((System.Drawing.Image)(resources.GetObject("pbUcuncuAraba.Image")));
            this.pbUcuncuAraba.Location = new System.Drawing.Point(503, 412);
            this.pbUcuncuAraba.Name = "pbUcuncuAraba";
            this.pbUcuncuAraba.Size = new System.Drawing.Size(57, 79);
            this.pbUcuncuAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUcuncuAraba.TabIndex = 3;
            this.pbUcuncuAraba.TabStop = false;
            // 
            // pbBirinciAraba
            // 
            this.pbBirinciAraba.Image = ((System.Drawing.Image)(resources.GetObject("pbBirinciAraba.Image")));
            this.pbBirinciAraba.Location = new System.Drawing.Point(184, 412);
            this.pbBirinciAraba.Name = "pbBirinciAraba";
            this.pbBirinciAraba.Size = new System.Drawing.Size(55, 79);
            this.pbBirinciAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBirinciAraba.TabIndex = 3;
            this.pbBirinciAraba.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(-5, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(613, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "bitiş";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBahis
            // 
            this.lblBahis.AutoSize = true;
            this.lblBahis.Location = new System.Drawing.Point(88, 111);
            this.lblBahis.Name = "lblBahis";
            this.lblBahis.Size = new System.Drawing.Size(0, 13);
            this.lblBahis.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Oynanan bahis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Oynanan Miktar";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(62, 264);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 13);
            this.lblBakiye.TabIndex = 8;
            // 
            // btnbahis
            // 
            this.btnbahis.Location = new System.Drawing.Point(17, 316);
            this.btnbahis.Name = "btnbahis";
            this.btnbahis.Size = new System.Drawing.Size(75, 23);
            this.btnbahis.TabIndex = 9;
            this.btnbahis.Text = "bahis oyna";
            this.btnbahis.UseVisualStyleBackColor = true;
            this.btnbahis.Click += new System.EventHandler(this.btnbahis_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(58, 290);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(44, 20);
            this.txtBakiye.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bakiye";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // arabaYarisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 489);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbahis);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBahis);
            this.Controls.Add(this.pbUcuncuAraba);
            this.Controls.Add(this.pbİkinciAraba);
            this.Controls.Add(this.pbBirinciAraba);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Name = "arabaYarisi";
            this.Text = "arabaYarisi";
            this.Load += new System.EventHandler(this.arabaYarisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbİkinciAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUcuncuAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirinciAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbİkinciAraba;
        private System.Windows.Forms.PictureBox pbUcuncuAraba;
        private System.Windows.Forms.PictureBox pbBirinciAraba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBahis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnbahis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}