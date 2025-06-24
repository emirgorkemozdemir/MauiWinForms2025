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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Veritabanı işlemi varsa öncelikle baglantıyı açıyorum
            BaglantiSinifi.baglanti.Open();

            // Komut oluşturuyorum
            SqlCommand cmd_giris = new SqlCommand("SELECT UserName,UserPassword FROM TableUser WHERE UserName=@pka AND UserPassword =@psifre", BaglantiSinifi.baglanti);

            // Parametrelere deger atıyorum
            cmd_giris.Parameters.AddWithValue("@pka", tboxKullaniciAdi.Text);
            cmd_giris.Parameters.AddWithValue("@psifre", ShaSinifi.sha_calistir(tboxSifre.Text));

            // İşlem sonucunda ya 1 veri ya da 0 veri gelecek. Bu yüzden Data Reader kullanmam daha mantıklı
            SqlDataReader veri_okuyucu = cmd_giris.ExecuteReader();

            // DataReader komutu çalıştırdı ve sonucu aldı. Buldugu sonucun adedi 1 ise giriş başarılı , 0 ise başarısız diyecegiz
            if (veri_okuyucu.HasRows)
            {
                MessageBox.Show("Giriş başarılı");
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }

            veri_okuyucu.Close();
            BaglantiSinifi.baglanti.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayit kayit_sayfasi = new Kayit();
            kayit_sayfasi.Show();
        }
    }
}
