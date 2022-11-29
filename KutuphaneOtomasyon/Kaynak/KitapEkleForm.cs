using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon.Kaynak
{
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }

        KutuphaneProjeEntities db = new KutuphaneProjeEntities();  
        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar=new Kitaplar();
            kitaplar.KitapAdi = kitapAdtxt.Text;
            kitaplar.KitapBasimNo =Convert.ToInt16(kitapBasimNonum.Value);
            kitaplar.YazarId=Convert.ToInt16(kitapYazarIdnum.Value);
            kitaplar.YayinEviId=Convert.ToInt16(kitapYayinEviIdnum.Value);
            kitaplar.SayfaSayisi=Convert.ToInt16(kitapSayfaSayisinum.Value);
            kitaplar.TurNo=Convert.ToInt16(kitapTurNonum.Value);

            db.Kitaplar.Add(kitaplar);
            db.SaveChanges();

            var kliste = db.Kitaplar.ToList();
            dataGridView1.DataSource = kliste.ToList();


        }

        private void KitapEkleForm_Load(object sender, EventArgs e)
        {
            var kliste = db.Kitaplar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }
    }
}
