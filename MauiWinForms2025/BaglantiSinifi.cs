using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiWinForms2025
{
    public class BaglantiSinifi
    {
        // statik yaptıım herhangi bir nesne veya class , uygulama içerisinde asla degişmeden kullanılır.
        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MauiWinFormsDB;Integrated Security=True;TrustServerCertificate=True");

        public static void baglantiyi_kontrol_et()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
    }
}
