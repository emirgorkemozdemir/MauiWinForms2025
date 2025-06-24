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

        private bool Kullanici_Adi_Var_Mi()
        {
            // Veritabanı işlemi yaptıgım için öncelikle baglantıyı açıyorum
            BaglantiSinifi.baglanti.Open();

            // Komut oluşturuyorum. Komutun içerisine durumuma göre bir query yazıyorum.
            SqlCommand cmd_kontrol = new SqlCommand("SELECT UserName FROM TableUser WHERE UserName =@pka", BaglantiSinifi.baglanti);

            // Parametreye deger atıyorum
            cmd_kontrol.Parameters.AddWithValue("@pka",tboxKullaniciAdi.Text.ToLower().Trim());

            // Komutumu yazdım, ancak bu komutun sonucu ya boş tablo olacak. Ya da bir tane veri bulacak.
            // O yüzden kullanıcı adı varsa , bu komutun sonucunun 1 gelmesi lazım.
            // Kullanıcı adı yoksa, komutun sonucunun 0 gelmesi lazım.

            // SQL'den c#'a veri okurken 2 yöntem var. Birisi SqlDataReader. Bu yöntemi çogunlukla tek veri bekliyorsak yaparız.
            // Yani yapacagımız işlem sonucunda bir veya 0 sonuç bekliyorsa SQLDatareader kullanmak daha mantıklıdır.
            SqlDataReader veri_okuyucu = cmd_kontrol.ExecuteReader();

            bool sonuc;

            // HasRows satır bulabildi mi demek.
            if (veri_okuyucu.HasRows== true)
            {
                sonuc= true;
            }
            else
            {
                sonuc= false;
            }


            // İşlem bittikten sonra data reader'Ların kapatılması gerekmekte.
            veri_okuyucu.Close();
            BaglantiSinifi.baglanti.Close();
            return sonuc;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            bool kullanici_adi_kontrol = Kullanici_Adi_Var_Mi();

            if (kullanici_adi_kontrol ==false)
            {
                // Her şeyden önce veritabanı işlemi varsa , baglantı açılır
                BaglantiSinifi.baglanti.Open();

                // Burada yaptıgım işlem gözünüzde veritabanına gidip new query demek gibi
                // canlanabilir. Yani yeni bir sorgu (query/command) oluşturuyoruz.
                SqlCommand cmd_kayit = new SqlCommand("INSERT INTO TableUser (UserName,UserPassword,UserRole) VALUES (@pka,@psifre,@prol)", BaglantiSinifi.baglanti);

                // Şifreyi hashleme yaptırıyoruz
                string hashli_sifre = ShaSinifi.sha_calistir(tboxSifre.Text.Trim());

                cmd_kayit.Parameters.AddWithValue("@pka", tboxKullaniciAdi.Text.ToLower().Trim());
                cmd_kayit.Parameters.AddWithValue("@psifre", hashli_sifre);
                cmd_kayit.Parameters.AddWithValue("@prol", 1);

                // gözünüzde yukarıdaki execute tuşuna basılmış gibi düşünebilirsiniz.
                cmd_kayit.ExecuteNonQuery();

                // unutmadan veritabanı baglantısını kapatıyorum
                BaglantiSinifi.baglanti.Close();

                MessageBox.Show("Kayıt başarılı");
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılmaktadır!");
            }

           
        }
    }
}
