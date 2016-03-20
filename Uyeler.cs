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
    public class Uyeler
    {
        public class yeniUye
        {
            public string adi = "";      
            public string soyadi = "";
            public string kullan = "";
            public string parola = "";
            public string tel = "";
            public string eposta = "";
            public string adres = "";

        }

        public void UyeEkle(yeniUye uye)
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = dbnesne.Baglanti;
            komut.CommandText = "INSERT INTO TST.kullEkle(kulAdi,kulSoyadi,kullanici,kulParola,kulTelefon,kulEposta,kulAdres) VALUES(@kulAdi,@kulSoyadi,@kullanici,@kulParola,@kulTelefon,@kulEposta,@kulAdres)";
            komut.Parameters.Add("@kulAdi", SqlDbType.NVarChar);
            komut.Parameters["@kulAdi"].Value = uye.adi;
            komut.Parameters.Add("@kulSoyadi", SqlDbType.NVarChar);
            komut.Parameters["@kulSoyadi"].Value = uye.soyadi;
            komut.Parameters.Add("@kullanici", SqlDbType.NVarChar);
            komut.Parameters["@kullanici"].Value = uye.kullan;
            komut.Parameters.Add("@kulParola", SqlDbType.NVarChar);
            komut.Parameters["@kulParola"].Value = uye.parola;
            komut.Parameters.Add("@kulTelefon", SqlDbType.Int);
            komut.Parameters["@kulTelefon"].Value = uye.tel;
            komut.Parameters.Add("@kulEposta", SqlDbType.NVarChar);
            komut.Parameters["@kulEposta"].Value = uye.eposta;
            komut.Parameters.Add("@kulAdres", SqlDbType.NVarChar);
            komut.Parameters["@kulAdres"].Value = uye.adres;
            komut.ExecuteNonQuery();
            SQLConn.DB.BaglantiKes();
        }
    }
}
