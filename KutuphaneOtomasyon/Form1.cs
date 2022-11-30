using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriTabaniylaCalisma;

namespace VeriTabaniylaCalisma
{
    public partial class Form1 : Form
    {
        Personel personel = new Personel();
        public Form1()
        {
            InitializeComponent();
            dgwPersonel.DataSource = personel.GetPersonel();
        }

        private void ClearControls()
        {
            txtId.Text = "";
            txtAdSoyad.Text = "";
            txtYas.Text = "";
            txtTelefon.Text = "";
            cmbCinsiyet.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            personel.Id = Convert.ToInt32(txtId.Text);
            personel.AdSoyad = txtAdSoyad.Text;
            personel.Yas = Convert.ToInt32(txtYas.Text);
            personel.Telefon = txtTelefon.Text;
            personel.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();
            var kontrol = personel.InsertPersonel(personel);
            dgwPersonel.DataSource = personel.GetPersonel();

            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Personel başarı ile eklendi");

            }
            else
            {
                MessageBox.Show("Hata lütfen tekrar deneyiniz");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            personel.Id = Convert.ToInt32(txtId.Text);
            personel.AdSoyad = txtAdSoyad.Text;
            personel.Yas = Convert.ToInt32(txtYas.Text);
            personel.Telefon = txtTelefon.Text;
            personel.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();

            var kontrol = personel.UpdatePersonel(personel);

            dgwPersonel.DataSource = personel.GetPersonel();

            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Personel başarı ile güncellendi");

            }
            else
            {
                MessageBox.Show("Hata lütfen tekrar deneyiniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            personel.Id = Convert.ToInt32(txtId.Text);


            var kontrol = personel.DeletePersonel(personel);

            dgwPersonel.DataSource = personel.GetPersonel();

            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Personel başarı ile silindi");

            }
            else
            {
                MessageBox.Show("Hata lütfen tekrar deneyiniz");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgwPersonel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwPersonel.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = dgwPersonel.CurrentRow.Cells[1].Value.ToString();
            txtYas.Text = dgwPersonel.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgwPersonel.CurrentRow.Cells[3].Value.ToString();
            cmbCinsiyet.Text = dgwPersonel.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

