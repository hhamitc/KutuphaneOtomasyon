﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyon
{
    public partial class GorevliGiris : Form
    {
        KutuphaneProjeEntities db = new KutuphaneProjeEntities();


        public GorevliGiris()
        {
            InitializeComponent();
        }

        private void personelGirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            //linq sorgusu
            var gorevli = db.Gorevliler.Where(x=>x.Gorevli_k_adi.Equals(gelenAd)&&x.Gorevli_sifre.Equals(gelenSifre)).FirstOrDefault();
            if (gorevli==null)
            {
                MessageBox.Show( "Kullanıcı adı veya şifre hatalı.");
            }
            else 
            {
                MessageBox.Show("Giriş Başarılı.");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }


        }
    }
}
