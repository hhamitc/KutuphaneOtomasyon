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
    public partial class AboneGuncelleForm : Form
    {

        KutuphaneProjeEntities db = new KutuphaneProjeEntities();
        
        
        public AboneGuncelleForm()
        {
            InitializeComponent();
        }

        public void listele()
        {
            var aboneler = db.Aboneler.ToList();
            dataGridView1.DataSource = aboneler.ToList();
        }

        private void AboneGuncelleForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aboneAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();   
            aboneCinsiyetcmb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();   
            aboneTelefontxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();   
            aboneMailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();   
            aboneTipcmb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();   
            aboneDurumcmb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();   
            aboneTarihtxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var abone = db.Aboneler.Where(x=>x.AboneId==secilenId).FirstOrDefault();
            abone.AboneAdi=aboneAdtxt.Text;
            abone.AboneAdi = aboneAdtxt.Text;
            abone.AboneCinsiyet = aboneCinsiyetcmb.Text;
            abone.AboneTelefon = aboneTelefontxt.Text;
            abone.AboneMail = aboneMailtxt.Text;
            abone.AbonelikTipi = aboneTipcmb.Text;
            abone.AbonelikDurumu = aboneDurumcmb.Text;
            abone.AbonelikTarihi = Convert.ToDateTime(aboneTarihtxt.Text);

            db.SaveChanges();
            listele();

        }
    }
}
