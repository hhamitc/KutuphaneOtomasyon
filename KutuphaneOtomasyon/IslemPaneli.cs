﻿using KutuphaneOtomasyon.Abone;
using KutuphaneOtomasyon.Kaynak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneProjeEntities db = new KutuphaneProjeEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {

            //kullanıcı butonları girişte kapalıdır.(ekle-güncelle-sil) 
            ekleAbonebtn.Visible = false;
            guncelleAbonebtn.Visible = false;
            silAbonebtn.Visible = false;

            // kaynak butonları girişte kapalıdır.(ekle-güncelle-sil)
            ekleKitapbtn.Visible = false;
            guncelleKitapbtn.Visible = false;
            silKitapbtn.Visible = false;

            ekleYazarbtn.Visible = false;
            guncelleYazarbtn.Visible = false;
            silYazarbtn.Visible = false;

            ekleYayinevibtn.Visible = false;
            guncelleYayinevibtn.Visible = false;
            silYayinevibtn.Visible = false;

            ekleTurbtn.Visible = false;
            guncelleTurbtn.Visible = false;
            silTurbtn.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleAbonebtn.Visible == false)
            {
                ekleAbonebtn.Visible = true;
                guncelleAbonebtn.Visible = true;
                silAbonebtn.Visible = true;
            }
            else
            {
                ekleAbonebtn.Visible = false;
                guncelleAbonebtn.Visible = false;
                silAbonebtn.Visible = false;

            }


            AboneListeForm alisteForm= new AboneListeForm();
            alisteForm.MdiParent= this;
            alisteForm.Show();

            
             
        }

        private void ekleAbonebtn_Click(object sender, EventArgs e)
        {
            AboneEkleForm ekleForm = new AboneEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void silAbonebtn_Click(object sender, EventArgs e)
        {
            AboneSilForm aSil = new AboneSilForm();
            aSil.MdiParent = this;
            aSil.Show();
        }

        private void guncelleAbonebtn_Click(object sender, EventArgs e)
        {
            AboneGuncelleForm aGuncelle = new AboneGuncelleForm();
            aGuncelle.MdiParent = this;
            aGuncelle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleKitapbtn.Visible == false)
            {
                ekleKitapbtn.Visible = true;
                guncelleKitapbtn.Visible = true;
                silKitapbtn.Visible = true;
                ekleYazarbtn.Visible = true;
                guncelleYazarbtn.Visible = true;
                silYazarbtn.Visible = true;

                ekleYayinevibtn.Visible = true;
                guncelleYayinevibtn.Visible = true;
                silYayinevibtn.Visible = true;

                ekleTurbtn.Visible = true;
                guncelleTurbtn.Visible = true;
                silTurbtn.Visible = true;


            }
            else
            {
                ekleKitapbtn.Visible = false;
                guncelleKitapbtn.Visible = false;
                silKitapbtn.Visible = false;
                ekleYazarbtn.Visible = false;
                guncelleYazarbtn.Visible = false;
                silYazarbtn.Visible = false;

                ekleYayinevibtn.Visible = false;
                guncelleYayinevibtn.Visible = false;
                silYayinevibtn.Visible = false;

                ekleTurbtn.Visible = false;
                guncelleTurbtn.Visible = false;
                silTurbtn.Visible = false;
            }

            KaynakListeForm kliste = new KaynakListeForm();
            kliste.MdiParent = this;
            kliste.Show();

        }

        private void ekleKitapbtn_Click(object sender, EventArgs e)
        {
            KitapEkleForm kEkle= new KitapEkleForm();
            kEkle.MdiParent = this;
            kEkle.Show();
        }

        private void silKitapbtn_Click(object sender, EventArgs e)
        {
            KitapSilForm kSil = new KitapSilForm();
            kSil.MdiParent = this;
            kSil.Show();
        }

        private void guncelleKitapbtn_Click(object sender, EventArgs e)
        {
            KitapGuncelleForm kGuncelle = new KitapGuncelleForm();
            kGuncelle.MdiParent = this;
            kGuncelle.Show();
        }






    }
}
