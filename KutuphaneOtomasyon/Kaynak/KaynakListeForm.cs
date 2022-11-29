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
    public partial class KaynakListeForm : Form
    {
        public KaynakListeForm()
        {
            InitializeComponent();
        }

        public void listele()
        {
            KutuphaneProjeEntities db = new KutuphaneProjeEntities();
            var kaynaklar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
       

        private void KaynakListeForm_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
