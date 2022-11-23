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
    public partial class Form1 : Form
    {
        KutuphaneProjeEntities db = new KutuphaneProjeEntities();


        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            //linq sorgusu
            var gorevli = db.Gorevliler.Where(x=>x.Gorevli_k_adi.Equals(gelenAd)&&x.Gorevli_sifre.Equals(gelenSifre)).FirstOrDefault();
            if (gorevli==null)
            {
                MessageBox.Show( "Kullanıcı adı veya şifre hatalı.");
            }
            else 
            {
                MessageBox.Show("Giriş Başarılı.");
            }

            
        }
    }
}
