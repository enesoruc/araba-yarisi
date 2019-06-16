namespace _02_TimerControl
{
    partial class bahis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bahis));
            this.txtBahis = new System.Windows.Forms.TextBox();
            this.btnBahis = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBahis
            // 
            this.txtBahis.BackColor = System.Drawing.Color.DimGray;
            this.txtBahis.Location = new System.Drawing.Point(227, 36);
            this.txtBahis.MaxLength = 1;
            this.txtBahis.Name = "txtBahis";
            this.txtBahis.Size = new System.Drawing.Size(22, 20);
            this.txtBahis.TabIndex = 0;
            this.txtBahis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBahis
            // 
            this.btnBahis.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBahis.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBahis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBahis.Location = new System.Drawing.Point(133, 107);
            this.btnBahis.Name = "btnBahis";
            this.btnBahis.Size = new System.Drawing.Size(75, 23);
            this.btnBahis.TabIndex = 1;
            this.btnBahis.Text = "Oyna";
            this.btnBahis.UseVisualStyleBackColor = false;
            this.btnBahis.Click += new System.EventHandler(this.btnBahis_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.DimGray;
            this.txtMiktar.Location = new System.Drawing.Point(227, 58);
            this.txtMiktar.MaxLength = 4;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(40, 20);
            this.txtMiktar.TabIndex = 2;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.BackColor = System.Drawing.Color.DimGray;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMiktar.Location = new System.Drawing.Point(110, 59);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(106, 13);
            this.lblMiktar.TabIndex = 3;
            this.lblMiktar.Text = "Yatırılacak Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bahis Yatırılacak Araba";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bahis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnBahis);
            this.Controls.Add(this.txtBahis);
            this.Controls.Add(this.pictureBox1);
            this.Name = "bahis";
            this.Text = "bahis";
            this.Load += new System.EventHandler(this.bahis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBahis;
        private System.Windows.Forms.Button btnBahis;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}