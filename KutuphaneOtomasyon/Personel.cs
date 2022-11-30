
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace VeriTabaniylaCalisma
{
    class Personel
    {
        int _id;
        string _adsoyad;
        int _yas;
        string _telefon;
        string _cinsiyet;

        public int Id { get => _id; set => _id = value; }
        public string AdSoyad { get => _adsoyad; set => _adsoyad = value; }
        public int Yas { get => _yas; set => _yas = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Cinsiyet { get => _cinsiyet; set => _cinsiyet = value; }

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string InsertQuery = "Insert Into Personel(Id,AdSoyad,Yas,Telefon,Cinsiyet) Values (@PersonelId,@PersonelAdSoyad,@PersonelYas,@PersonelTelefon,@PersonelCinsiyet)";

        public bool InsertPersonel(Personel personel)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@PersonelId", personel.Id);
                    com.Parameters.AddWithValue("@PersonelAdSoyad", personel.AdSoyad);
                    com.Parameters.AddWithValue("@PersonelYas", personel.Yas);
                    com.Parameters.AddWithValue("@PersonelTelefon", personel.Telefon);
                    com.Parameters.AddWithValue("@PersonelCinsiyet", personel.Cinsiyet);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string UpdateQuery = "Update Personel set AdSoyad=@PersonelAdSoyad, Yas=@PersonelYas, Telefon=@PersonelTelefon, Cinsiyet=@PersonelCinsiyet where Id=@PersonelId";

        public bool UpdatePersonel(Personel personel)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@PersonelId", personel.Id);
                    com.Parameters.AddWithValue("@PersonelAdSoyad", personel.AdSoyad);
                    com.Parameters.AddWithValue("@PersonelYas", personel.Yas);
                    com.Parameters.AddWithValue("@PersonelTelefon", personel.Telefon);
                    com.Parameters.AddWithValue("@PersonelCinsiyet", personel.Cinsiyet);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string DeleteQuery = "Delete from Personel where Id=@PersonelId";
        public bool DeletePersonel(Personel personel)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@PersonelId", personel.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string SelectQuery = "Select * from Personel";
        public DataTable GetPersonel()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;

        }
    }
}
