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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneProjeEntities db = new KutuphaneProjeEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleAbonebtn.Visible = false;
            guncelleAbonebtn.Visible = false;
            silAbonebtn.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleAbonebtn.Visible == false)
            {
                ekleAbonebtn.Visible = true;
                guncelleAbonebtn.Visible = true;
                silAbonebtn.Visible = true;
            }
            else
            {
                ekleAbonebtn.Visible = false;
                guncelleAbonebtn.Visible = false;
                silAbonebtn.Visible = false;
            }


            AboneListeForm alisteForm= new AboneListeForm();
            alisteForm.MdiParent= this;
            alisteForm.Show();

            
             
        }
    }
}
