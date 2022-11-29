namespace KutuphaneOtomasyon.Kaynak
{
    partial class KitapGuncelleForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.kitapTurNonum = new System.Windows.Forms.NumericUpDown();
            this.kitapSayfaSayisinum = new System.Windows.Forms.NumericUpDown();
            this.kitapYayinEviIdnum = new System.Windows.Forms.NumericUpDown();
            this.kitapYazarIdnum = new System.Windows.Forms.NumericUpDown();
            this.kitapBasimNonum = new System.Windows.Forms.NumericUpDown();
            this.kitapAdtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kitapTurNonum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSayfaSayisinum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYayinEviIdnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYazarIdnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBasimNonum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 41);
            this.button1.TabIndex = 51;
            this.button1.Text = "Kitap Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kitapTurNonum
            // 
            this.kitapTurNonum.Location = new System.Drawing.Point(98, 158);
            this.kitapTurNonum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kitapTurNonum.Name = "kitapTurNonum";
            this.kitapTurNonum.Size = new System.Drawing.Size(100, 20);
            this.kitapTurNonum.TabIndex = 50;
            // 
            // kitapSayfaSayisinum
            // 
            this.kitapSayfaSayisinum.Location = new System.Drawing.Point(98, 132);
            this.kitapSayfaSayisinum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kitapSayfaSayisinum.Name = "kitapSayfaSayisinum";
            this.kitapSayfaSayisinum.Size = new System.Drawing.Size(100, 20);
            this.kitapSayfaSayisinum.TabIndex = 49;
            // 
            // kitapYayinEviIdnum
            // 
            this.kitapYayinEviIdnum.Location = new System.Drawing.Point(98, 102);
            this.kitapYayinEviIdnum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kitapYayinEviIdnum.Name = "kitapYayinEviIdnum";
            this.kitapYayinEviIdnum.Size = new System.Drawing.Size(100, 20);
            this.kitapYayinEviIdnum.TabIndex = 48;
            // 
            // kitapYazarIdnum
            // 
            this.kitapYazarIdnum.Location = new System.Drawing.Point(98, 71);
            this.kitapYazarIdnum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kitapYazarIdnum.Name = "kitapYazarIdnum";
            this.kitapYazarIdnum.Size = new System.Drawing.Size(100, 20);
            this.kitapYazarIdnum.TabIndex = 47;
            // 
            // kitapBasimNonum
            // 
            this.kitapBasimNonum.Location = new System.Drawing.Point(98, 41);
            this.kitapBasimNonum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kitapBasimNonum.Name = "kitapBasimNonum";
            this.kitapBasimNonum.Size = new System.Drawing.Size(100, 20);
            this.kitapBasimNonum.TabIndex = 46;
            // 
            // kitapAdtxt
            // 
            this.kitapAdtxt.Location = new System.Drawing.Point(98, 12);
            this.kitapAdtxt.Name = "kitapAdtxt";
            this.kitapAdtxt.Size = new System.Drawing.Size(100, 20);
            this.kitapAdtxt.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tür No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Yayın Evi Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Yazar Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Kitap Basim No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kitap Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 470);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // KitapGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kitapTurNonum);
            this.Controls.Add(this.kitapSayfaSayisinum);
            this.Controls.Add(this.kitapYayinEviIdnum);
            this.Controls.Add(this.kitapYazarIdnum);
            this.Controls.Add(this.kitapBasimNonum);
            this.Controls.Add(this.kitapAdtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapGuncelleForm";
            this.Text = "KitapGuncelleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitapGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapTurNonum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSayfaSayisinum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYayinEviIdnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYazarIdnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBasimNonum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown kitapTurNonum;
        private System.Windows.Forms.NumericUpDown kitapSayfaSayisinum;
        private System.Windows.Forms.NumericUpDown kitapYayinEviIdnum;
        private System.Windows.Forms.NumericUpDown kitapYazarIdnum;
        private System.Windows.Forms.NumericUpDown kitapBasimNonum;
        private System.Windows.Forms.TextBox kitapAdtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}