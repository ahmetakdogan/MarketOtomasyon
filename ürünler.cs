using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace market
{
    class ürünler
    {
        public class yeniÜrün
        {
            public string adi = "";
            public string kod = "";
            public string marka = "";
            public string adet = "";
            public string fiyat = "";

        }

        public void ürünEkle(yeniÜrün ürün)
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();

            string ürünEkle = "INSERT INTO TST.ürünler(ürünAdi,ürünKodu,marka,adet,fiyat) VALUES ('" + ürün.adi + "','" + ürün.kod + "','" + ürün.marka + "','" + ürün.adet + "','" + ürün.fiyat + "')";
            SqlCommand komut = new SqlCommand(ürünEkle, dbnesne.Baglanti);
            komut.Connection = dbnesne.Baglanti;
            komut.CommandText = ürünEkle;
            komut.ExecuteNonQuery();
        }
    }
}
