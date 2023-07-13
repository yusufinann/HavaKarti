namespace HavaKarti
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblSicaklik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblRuzgar = new System.Windows.Forms.Label();
            this.LblNem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.LblYagis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSTANBUL,TR";
            // 
            // LblSicaklik
            // 
            this.LblSicaklik.AutoSize = true;
            this.LblSicaklik.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSicaklik.ForeColor = System.Drawing.Color.White;
            this.LblSicaklik.Location = new System.Drawing.Point(258, 233);
            this.LblSicaklik.Name = "LblSicaklik";
            this.LblSicaklik.Size = new System.Drawing.Size(251, 106);
            this.LblSicaklik.TabIndex = 1;
            this.LblSicaklik.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "İSTANBUL,TR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bugün";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(485, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(34, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rüzgar:";
            // 
            // LblRuzgar
            // 
            this.LblRuzgar.AutoSize = true;
            this.LblRuzgar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRuzgar.ForeColor = System.Drawing.Color.White;
            this.LblRuzgar.Location = new System.Drawing.Point(133, 391);
            this.LblRuzgar.Name = "LblRuzgar";
            this.LblRuzgar.Size = new System.Drawing.Size(36, 28);
            this.LblRuzgar.TabIndex = 7;
            this.LblRuzgar.Text = "00";
            // 
            // LblNem
            // 
            this.LblNem.AutoSize = true;
            this.LblNem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNem.ForeColor = System.Drawing.Color.White;
            this.LblNem.Location = new System.Drawing.Point(133, 443);
            this.LblNem.Name = "LblNem";
            this.LblNem.Size = new System.Drawing.Size(36, 28);
            this.LblNem.TabIndex = 9;
            this.LblNem.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(34, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nem:";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDurum.ForeColor = System.Drawing.Color.White;
            this.LblDurum.Location = new System.Drawing.Point(271, 363);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(73, 28);
            this.LblDurum.TabIndex = 10;
            this.LblDurum.Text = "Bugün";
            // 
            // LblYagis
            // 
            this.LblYagis.AutoSize = true;
            this.LblYagis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYagis.ForeColor = System.Drawing.Color.White;
            this.LblYagis.Location = new System.Drawing.Point(133, 499);
            this.LblYagis.Name = "LblYagis";
            this.LblYagis.Size = new System.Drawing.Size(88, 28);
            this.LblYagis.TabIndex = 12;
            this.LblYagis.Text = "00.00 %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(34, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yağış:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "00.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(34, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sıcaklık:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(192, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(57)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(574, 647);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblYagis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblNem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblRuzgar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSicaklik);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSicaklik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblRuzgar;
        private System.Windows.Forms.Label LblNem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Label LblYagis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

