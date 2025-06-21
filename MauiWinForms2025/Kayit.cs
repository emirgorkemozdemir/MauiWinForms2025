using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MauiWinForms2025
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            // Her şeyden önce veritabanı işlemi varsa , baglantı açılır
            BaglantiSinifi.baglanti.Open();

            // Burada yaptıgım işlem gözünüzde veritabanına gidip new query demek gibi
            // canlanabilir. Yani yeni bir sorgu (query/command) oluşturuyoruz.
            SqlCommand cmd_kayit = new SqlCommand("INSERT INTO TableUser (UserName,UserPassword,UserRole) VALUES (@pka,@psifre,@prol)",BaglantiSinifi.baglanti);

            cmd_kayit.Parameters.AddWithValue("@pka",tboxKullaniciAdi.Text);
            cmd_kayit.Parameters.AddWithValue("@psifre",tboxSifre.Text);
            cmd_kayit.Parameters.AddWithValue("@prol",1);

            // gözünüzde yukarıdaki execute tuşuna basılmış gibi düşünebilirsiniz.
            cmd_kayit.ExecuteNonQuery();

            // unutmadan veritabanı baglantısını kapatıyorum
            BaglantiSinifi.baglanti.Close();

            MessageBox.Show("Kayıt başarılı");
        }
    }
}
