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
    public partial class AboneSilForm : Form
    {
        KutuphaneProjeEntities db = new KutuphaneProjeEntities();

        public AboneSilForm()
        {
            InitializeComponent();
        }

        public void listele()
        {
            var aboneler = db.Aboneler.ToList();
            dataGridView1.DataSource = aboneler.ToList();
        }

        private void AboneSilForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var abone = db.Aboneler.Where(x => x.AboneId == secilenId).FirstOrDefault();
            db.Aboneler.Remove(abone);
            db.SaveChanges();
            listele();
        }
    }
}
