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
    public partial class KitapGuncelleForm : Form
    {
        public KitapGuncelleForm()
        {
            InitializeComponent();
        }

        KutuphaneProjeEntities db = new KutuphaneProjeEntities();

        private void KitapGuncelleForm_Load(object sender, EventArgs e)
        {
            var kitaplar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kitapAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
            kitapBasimNonum.Value =Convert.ToInt32( dataGridView1.CurrentRow.Cells[2].Value);
            kitapYazarIdnum.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value); 
            kitapYayinEviIdnum.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value); 
            kitapSayfaSayisinum.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            kitapTurNonum.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKitap = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKitap = db.Kitaplar.Where(x=>x.KitapId==secilenKitap).FirstOrDefault();
            guncellenecekKitap.KitapAdi = kitapAdtxt.Text;
            guncellenecekKitap.KitapBasimNo = Convert.ToInt32(kitapBasimNonum.Value);
            guncellenecekKitap.YazarId = Convert.ToInt32(kitapYazarIdnum.Value);
            guncellenecekKitap.YayinEviId = Convert.ToInt32(kitapYayinEviIdnum.Value);
            guncellenecekKitap.SayfaSayisi = Convert.ToInt32(kitapSayfaSayisinum.Value);
            guncellenecekKitap.TurNo = Convert.ToInt32(kitapTurNonum.Value);

            db.SaveChanges();

            var kitaplar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

        }
    }
}
