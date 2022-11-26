namespace KutuphaneOtomasyon
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.silAbonebtn = new System.Windows.Forms.Button();
            this.guncelleAbonebtn = new System.Windows.Forms.Button();
            this.ekleAbonebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.silAbonebtn);
            this.panel1.Controls.Add(this.guncelleAbonebtn);
            this.panel1.Controls.Add(this.ekleAbonebtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 552);
            this.panel1.TabIndex = 0;
            // 
            // silAbonebtn
            // 
            this.silAbonebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silAbonebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silAbonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silAbonebtn.Image = ((System.Drawing.Image)(resources.GetObject("silAbonebtn.Image")));
            this.silAbonebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silAbonebtn.Location = new System.Drawing.Point(0, 168);
            this.silAbonebtn.Name = "silAbonebtn";
            this.silAbonebtn.Size = new System.Drawing.Size(200, 56);
            this.silAbonebtn.TabIndex = 3;
            this.silAbonebtn.Text = "Sil";
            this.silAbonebtn.UseVisualStyleBackColor = false;
            this.silAbonebtn.Click += new System.EventHandler(this.silAbonebtn_Click);
            // 
            // guncelleAbonebtn
            // 
            this.guncelleAbonebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guncelleAbonebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guncelleAbonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleAbonebtn.Image = ((System.Drawing.Image)(resources.GetObject("guncelleAbonebtn.Image")));
            this.guncelleAbonebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleAbonebtn.Location = new System.Drawing.Point(0, 112);
            this.guncelleAbonebtn.Name = "guncelleAbonebtn";
            this.guncelleAbonebtn.Size = new System.Drawing.Size(200, 56);
            this.guncelleAbonebtn.TabIndex = 2;
            this.guncelleAbonebtn.Text = "Güncelle";
            this.guncelleAbonebtn.UseVisualStyleBackColor = false;
            // 
            // ekleAbonebtn
            // 
            this.ekleAbonebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ekleAbonebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleAbonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleAbonebtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleAbonebtn.Image")));
            this.ekleAbonebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleAbonebtn.Location = new System.Drawing.Point(0, 56);
            this.ekleAbonebtn.Name = "ekleAbonebtn";
            this.ekleAbonebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ekleAbonebtn.Size = new System.Drawing.Size(200, 56);
            this.ekleAbonebtn.TabIndex = 1;
            this.ekleAbonebtn.Text = "Ekle";
            this.ekleAbonebtn.UseVisualStyleBackColor = false;
            this.ekleAbonebtn.Click += new System.EventHandler(this.ekleAbonebtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aboneler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(200, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(937, 37);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 552);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ekleAbonebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button silAbonebtn;
        private System.Windows.Forms.Button guncelleAbonebtn;
    }
}