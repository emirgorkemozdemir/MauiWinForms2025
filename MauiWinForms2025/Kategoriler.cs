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

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            BaglantiSinifi.baglantiyi_kontrol_et();

            SqlCommand cmd_yukle = new SqlCommand("SELECT * FROM TableCategory",BaglantiSinifi.baglanti);

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

        
        }
    }
}
