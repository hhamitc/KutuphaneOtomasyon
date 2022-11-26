namespace KutuphaneOtomasyon.Abone
{
    partial class AboneGuncelleForm
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
            this.aboneCinsiyetcmb = new System.Windows.Forms.ComboBox();
            this.aboneDurumcmb = new System.Windows.Forms.ComboBox();
            this.aboneTipcmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.aboneTarihtxt = new System.Windows.Forms.TextBox();
            this.aboneMailtxt = new System.Windows.Forms.TextBox();
            this.aboneTelefontxt = new System.Windows.Forms.TextBox();
            this.aboneAdtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboneCinsiyetcmb
            // 
            this.aboneCinsiyetcmb.FormattingEnabled = true;
            this.aboneCinsiyetcmb.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.aboneCinsiyetcmb.Location = new System.Drawing.Point(106, 60);
            this.aboneCinsiyetcmb.Name = "aboneCinsiyetcmb";
            this.aboneCinsiyetcmb.Size = new System.Drawing.Size(100, 21);
            this.aboneCinsiyetcmb.TabIndex = 34;
            // 
            // aboneDurumcmb
            // 
            this.aboneDurumcmb.FormattingEnabled = true;
            this.aboneDurumcmb.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.aboneDurumcmb.Location = new System.Drawing.Point(106, 167);
            this.aboneDurumcmb.Name = "aboneDurumcmb";
            this.aboneDurumcmb.Size = new System.Drawing.Size(100, 21);
            this.aboneDurumcmb.TabIndex = 33;
            // 
            // aboneTipcmb
            // 
            this.aboneTipcmb.FormattingEnabled = true;
            this.aboneTipcmb.Items.AddRange(new object[] {
            "STANDART",
            "ÖĞRENCİ"});
            this.aboneTipcmb.Location = new System.Drawing.Point(106, 140);
            this.aboneTipcmb.Name = "aboneTipcmb";
            this.aboneTipcmb.Size = new System.Drawing.Size(100, 21);
            this.aboneTipcmb.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 564);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 47);
            this.button1.TabIndex = 30;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboneTarihtxt
            // 
            this.aboneTarihtxt.Location = new System.Drawing.Point(106, 198);
            this.aboneTarihtxt.Name = "aboneTarihtxt";
            this.aboneTarihtxt.Size = new System.Drawing.Size(100, 20);
            this.aboneTarihtxt.TabIndex = 29;
            // 
            // aboneMailtxt
            // 
            this.aboneMailtxt.Location = new System.Drawing.Point(106, 116);
            this.aboneMailtxt.Name = "aboneMailtxt";
            this.aboneMailtxt.Size = new System.Drawing.Size(100, 20);
            this.aboneMailtxt.TabIndex = 28;
            // 
            // aboneTelefontxt
            // 
            this.aboneTelefontxt.Location = new System.Drawing.Point(106, 90);
            this.aboneTelefontxt.Name = "aboneTelefontxt";
            this.aboneTelefontxt.Size = new System.Drawing.Size(100, 20);
            this.aboneTelefontxt.TabIndex = 27;
            // 
            // aboneAdtxt
            // 
            this.aboneAdtxt.Location = new System.Drawing.Point(106, 34);
            this.aboneAdtxt.Name = "aboneAdtxt";
            this.aboneAdtxt.Size = new System.Drawing.Size(100, 20);
            this.aboneAdtxt.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Abonelik Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ad:";
            // 
            // AboneGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 621);
            this.Controls.Add(this.aboneCinsiyetcmb);
            this.Controls.Add(this.aboneDurumcmb);
            this.Controls.Add(this.aboneTipcmb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aboneTarihtxt);
            this.Controls.Add(this.aboneMailtxt);
            this.Controls.Add(this.aboneTelefontxt);
            this.Controls.Add(this.aboneAdtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AboneGuncelleForm";
            this.Text = "AboneGuncelleForm";
            this.Load += new System.EventHandler(this.AboneGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox aboneCinsiyetcmb;
        private System.Windows.Forms.ComboBox aboneDurumcmb;
        private System.Windows.Forms.ComboBox aboneTipcmb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox aboneTarihtxt;
        private System.Windows.Forms.TextBox aboneMailtxt;
        private System.Windows.Forms.TextBox aboneTelefontxt;
        private System.Windows.Forms.TextBox aboneAdtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}