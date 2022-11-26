using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon.Abone
{
    public partial class AboneEkleForm : Form
    {
        KutuphaneProjeEntities db = new KutuphaneProjeEntities();
        public AboneEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aboneler aboneler = new Aboneler();
            aboneler.AboneAdi = aboneAdtxt.Text;
            aboneler.AboneCinsiyet = aboneCinsiyetcmb.Text;
            aboneler.AboneTelefon = aboneTelefontxt.Text;
            aboneler.AboneMail = aboneMailtxt.Text;
            aboneler.AbonelikTipi = aboneTipcmb.Text;
            aboneler.AbonelikDurumu = aboneDurumcmb.Text;
            aboneler.AbonelikTarihi = Convert.ToDateTime(aboneTarihtxt.Text);

            db.Aboneler.Add(aboneler);
            db.SaveChanges();
            listele();

            aboneAdtxt.Clear();
            aboneCinsiyetcmb.SelectedIndex = -1;
            aboneTipcmb.SelectedIndex = -1;
            aboneDurumcmb.SelectedIndex = -1;
            aboneTelefontxt.Clear();
            aboneMailtxt.Clear();
            aboneTarihtxt.Clear();
        }

        public void listele()
        {
            var aboneler = db.Aboneler.ToList();
            dataGridView1.DataSource = aboneler.ToList();
        }
        private void AboneEkleForm_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
