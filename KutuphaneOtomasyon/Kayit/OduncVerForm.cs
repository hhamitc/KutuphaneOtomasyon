using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //listeledim.
            var kayitlar = db.Islem.ToList();
            dataGridView1.DataSource= kayitlar.ToList();

            //kolon adları düzenlendi
            dataGridView1.Columns[0].HeaderText= "IslemNo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananTelefon=TelefonBultxt.Text;
            var aboneVarMi = db.Aboneler.Where(x => x.AboneTelefon==arananTelefon).FirstOrDefault();
            label2.Text="Abone Adı: " + aboneVarMi.AboneAdi + "\nAbone Telefon: " + aboneVarMi.AboneTelefon ;
        }
    }
}
