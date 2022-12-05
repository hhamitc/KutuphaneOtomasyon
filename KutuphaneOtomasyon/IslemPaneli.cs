using KutuphaneOtomasyon.Abone;
using KutuphaneOtomasyon.Kayit;
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


        private AboneListeForm alisteForm; 
        /// <summary>
        /// kullanıcı liste ve butonları açar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            
            if (ekleAbonebtn.Visible == false)
            {
                ekleAbonebtn.Visible = true;
                guncelleAbonebtn.Visible = true;
                silAbonebtn.Visible = true;

                alisteForm= new AboneListeForm();

                alisteForm.MdiParent = this;
                alisteForm.Show();
            }
            else
            {
                ekleAbonebtn.Visible = false;
                guncelleAbonebtn.Visible = false;
                silAbonebtn.Visible = false;
                //alisteForm.Hide();
                alisteForm.Close();
            }


            

            
             
        }
        private AboneEkleForm aekleForm;
        private bool ekleAboneDurum = false;
        private void ekleAbonebtn_Click(object sender, EventArgs e)
        {
            
            if (ekleAboneDurum == false)
            {
                aekleForm = new AboneEkleForm();
                aekleForm.MdiParent = this;
                aekleForm.Show();
                ekleAboneDurum = true;
            }
            else
            {
                aekleForm.Close();
                ekleAboneDurum = false;
            }
            
        }
        private AboneSilForm asilForm;
        private bool silAboneDurum = false;
        private void silAbonebtn_Click(object sender, EventArgs e)
        {
            if (silAboneDurum == false)

            {   asilForm = new AboneSilForm();
                asilForm.MdiParent = this;
                asilForm.Show();
                silAboneDurum = true;
            }
            else
            {
                asilForm.Close();
                silAboneDurum = false;
            }
           
        }

        private AboneGuncelleForm aguncelleForm;
        private bool guncelleAboneDurum = false;
        private void guncelleAbonebtn_Click(object sender, EventArgs e)
        {
            if  (guncelleAboneDurum == false)
            {
                aguncelleForm = new AboneGuncelleForm();
                aguncelleForm.MdiParent = this;
                aguncelleForm.Show();
                guncelleAboneDurum = true;
            }
            else
            {
                aguncelleForm.Close();
                guncelleAboneDurum= false;
            }
        }
        private KaynakListeForm klisteForm;
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

                klisteForm = new KaynakListeForm();

                klisteForm.MdiParent = this;
                klisteForm.Show();


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

                klisteForm.Close();

            }

           

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

        private void button3_Click(object sender, EventArgs e)
        {
            OduncVerForm odunc = new OduncVerForm();
            odunc.MdiParent = this;
            odunc.Show();
        }
    }
}
