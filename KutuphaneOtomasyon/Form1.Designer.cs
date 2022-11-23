namespace KutuphaneOtomasyon
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
            this.adGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreGiristxt = new System.Windows.Forms.TextBox();
            this.personelGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adGiristxt
            // 
            this.adGiristxt.BackColor = System.Drawing.SystemColors.Menu;
            this.adGiristxt.Location = new System.Drawing.Point(118, 182);
            this.adGiristxt.Name = "adGiristxt";
            this.adGiristxt.Size = new System.Drawing.Size(100, 20);
            this.adGiristxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // sifreGiristxt
            // 
            this.sifreGiristxt.BackColor = System.Drawing.SystemColors.Menu;
            this.sifreGiristxt.Location = new System.Drawing.Point(118, 223);
            this.sifreGiristxt.Name = "sifreGiristxt";
            this.sifreGiristxt.Size = new System.Drawing.Size(100, 20);
            this.sifreGiristxt.TabIndex = 2;
            // 
            // personelGirisBtn
            // 
            this.personelGirisBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.personelGirisBtn.Location = new System.Drawing.Point(92, 291);
            this.personelGirisBtn.Name = "personelGirisBtn";
            this.personelGirisBtn.Size = new System.Drawing.Size(75, 23);
            this.personelGirisBtn.TabIndex = 4;
            this.personelGirisBtn.Text = "Giriş";
            this.personelGirisBtn.UseVisualStyleBackColor = false;
            this.personelGirisBtn.Click += new System.EventHandler(this.personelGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(258, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personelGirisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreGiristxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adGiristxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adGiristxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifreGiristxt;
        private System.Windows.Forms.Button personelGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

