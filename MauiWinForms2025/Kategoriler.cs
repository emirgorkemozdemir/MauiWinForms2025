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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void KategorileriYukle()
        {
            BaglantiSinifi.baglantiyi_kontrol_et();

            SqlCommand cmd_yukle = new SqlCommand("SELECT * FROM TableCategory", BaglantiSinifi.baglanti);

            // Şu ana kadar gördügümüz kısımlardan biraz daha farklı olacak çünkü toplu olarak veri okuyoruz.
            // İlk olarak veritabanından gelen verilerin türlerini buraya dönüştürmemiz gerekiyor.
            // Bu dönüşümü SqlDataAdapter yapacak.

            SqlDataAdapter da = new SqlDataAdapter(cmd_yukle);

            // Daha sonrasında hafızada boş bir tablo açalım. Bu tabloyu datagridview'a yansıtacagız
            DataTable tablo = new DataTable();

            // Tabloyu data adapter'dan dolduracagız
            da.Fill(tablo);

            // Son olarak sonucu datagrid'e yansıtıyorum
            dataGridView1.DataSource = tablo;

            // ilk satırı gizliyorum
            dataGridView1.Columns[0].Visible = false;
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BaglantiSinifi.baglantiyi_kontrol_et();

            SqlCommand cmd_ekle = new SqlCommand("INSERT INTO TableCategory (CategoryName) VALUES (@pad)", BaglantiSinifi.baglanti);

            cmd_ekle.Parameters.AddWithValue("@pad", tboxKategoriAdi.Text);

            cmd_ekle.ExecuteNonQuery();

            KategorileriYukle();
        }

        // Farklı fonksiyonlarda bunu kullanacagım için dışarı açtım.
        private int secili_id = -1;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                secili_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                tboxDuzenle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Boş bir kısma tıkladınız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            BaglantiSinifi.baglantiyi_kontrol_et();

            SqlCommand cmd_sil = new SqlCommand("DELETE FROM TableCategory WHERE CategoryID = @pid", BaglantiSinifi.baglanti);

            cmd_sil.Parameters.AddWithValue("@pid", secili_id);

            cmd_sil.ExecuteNonQuery();

            KategorileriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            BaglantiSinifi.baglantiyi_kontrol_et();

            SqlCommand cmd_duzenle = new SqlCommand("UPDATE TableCategory SET CategoryName=@pad WHERE CategoryID=@pid",BaglantiSinifi.baglanti);

            cmd_duzenle.Parameters.AddWithValue("@pad",tboxDuzenle.Text);
            cmd_duzenle.Parameters.AddWithValue("@pid", secili_id);

            cmd_duzenle.ExecuteNonQuery();

            KategorileriYukle();
        }
    }
}
