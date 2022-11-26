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
    public partial class AboneListeForm : Form
    {
        public AboneListeForm()
        {
            InitializeComponent();
        }
        public void listele()  
        {
            KutuphaneProjeEntities db = new KutuphaneProjeEntities();
            var aboneler = db.Aboneler.ToList();
            dataGridView1.DataSource= aboneler.ToList();
        }
        private void AboneListeForm_Load(object sender, EventArgs e)
        {
            listele(); 
        }
    }
}
