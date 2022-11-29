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
    public partial class KitapSilForm : Form
    {
        public KitapSilForm()
        {
            InitializeComponent();
        }

        KutuphaneProjeEntities db = new KutuphaneProjeEntities();
        private void KitapSilForm_Load(object sender, EventArgs e)
        {
            var kitaplar=db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenKitap = db.Kitaplar.Where(x => x.KitapId == secilenId).FirstOrDefault();
            db.Kitaplar.Remove(silinenKitap);
            db.SaveChanges();

            var kitaplar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }
    }
}
