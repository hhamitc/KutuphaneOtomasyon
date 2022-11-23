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
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            if (gelenAd.Equals("admin") && gelenSifre.Equals("123"))
            {
                MessageBox.Show("Giriş Başarılı."+MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı."+MessageBoxIcon.Warning);
            }
        }
    }
}
