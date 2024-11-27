using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyon.Kayit
{
    public partial class OduncVerForm : Form
    {


        public OduncVerForm()
        {
            InitializeComponent();
        }

        KutuphaneProjeEntities db = new KutuphaneProjeEntities();

        private void OduncVerForm_Load(object sender, EventArgs e)
        {

            //işlemleri listeledim.
            var kayitlar = db.Islem.ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            //kitapları listeledim.
            var kitaplar = db.Kitaplar.ToList();
            dataGridView2.DataSource = kitaplar.ToList();

            //kolon adları düzenlendi
            dataGridView1.Columns[0].HeaderText = "IslemNo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananTelefon = TelefonBultxt.Text;
            var aboneVarMi = db.Aboneler.Where(x => x.AboneTelefon == arananTelefon).FirstOrDefault();


            if (aboneVarMi != null)
            {
                label2.Text = "\nAbone Id: " + aboneVarMi.AboneId + "\nAbone Adı: " + aboneVarMi.AboneAdi + "\nAbone Telefon: " + aboneVarMi.AboneTelefon + "\nAbone Durum: " + aboneVarMi.AbonelikDurumu;
            }
            else
            {
                label2.Text = "Böyle bir kullanıcı yok.";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //filtreleme eklendi
            string gelenAd = textBox1.Text;
            var bulnanKitaplar = db.Kitaplar.Where(x => x.KitapAdi.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulnanKitaplar;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //Aboneyi aldım.
            string secilenKisiTelefon = TelefonBultxt.Text;
            var secilenKisi = db.Aboneler.Where(x => x.AboneTelefon.Equals(secilenKisiTelefon)).FirstOrDefault();

            //Kitabı aldık
            int secilenKitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.Kitaplar.Where(x => x.KitapId == secilenKitapId).FirstOrDefault();


            Islem yeniIslem = new Islem();
            yeniIslem.KitapId = secilenKitap.KitapId;
            yeniIslem.AboneId = secilenKisi.AboneId;
            yeniIslem.GorevliId = 1; // Giriş yapan kullanıcıyı eklemeyi bulamadım.Sonra bakacağım.
            yeniIslem.AlisTarihi = DateTime.Today;
            yeniIslem.TeslimTarihi = null /*DateTime.Today.AddDays(15)*/;

            db.Islem.Add(yeniIslem);
            db.SaveChanges();

            //işlemleri listeledim.
            var kayitlar = db.Islem.ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            //kitapları listeledim.
            var kitaplar = db.Kitaplar.ToList();
            dataGridView2.DataSource = kitaplar.ToList();

            MessageBox.Show("Ödünç verme işlemi yapıldı.", "Ödünç Ver.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Burada teslim al butonuyla, kullanıcının telefonundan işlemlerini getirme ve teslim tarihi null olan işleme bu günün tarihini yazdırma işlemi yaptırmaya çalıştım ama yapamadım.....

            // !!!!!!!!OduncVerFormDesigner kısmında 121. satırı da yorum satırından çıkar bunu denemek için.!!!!!!


            //Aboneyi aldım.
            string secilenKisiTelefon = TelefonBultxt.Text;
            var secilenKisi = db.Aboneler.Where(x => x.AboneTelefon.Equals(secilenKisiTelefon)).FirstOrDefault();

            //Islemi aldım
            int secilenIslemId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var secilenIslem = db.Islem.Where(x => x.IslemId == secilenIslemId).FirstOrDefault();

            Islem teslimAl = new Islem();
            if (secilenIslem.TeslimTarihi == null)
            {
                secilenIslem.TeslimTarihi = DateTime.Now;
                var tarih1 = Convert.ToDateTime(secilenIslem.TeslimTarihi);
                var tarih2 = Convert.ToDateTime(secilenIslem.AlisTarihi);

                var GunFarki = (tarih1 - tarih2).Days;
                secilenIslem.GunFarki = Convert.ToInt32(GunFarki);


                //secilenIslem.GunFarki = Convert.ToInt32(secilenIslem.TeslimTarihi - secilenIslem.AlisTarihi);
                MessageBox.Show("Kayıt Tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen doğru işlemi seçtiğinizden emin olun!", "Kayıt Eklendi", MessageBoxButtons.RetryCancel);
            }

            //işlemleri listeledim.
            var kayitlar = db.Islem.ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            db.SaveChanges();
        }
    }
}
