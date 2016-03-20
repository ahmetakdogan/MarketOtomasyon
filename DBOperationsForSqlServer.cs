using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Configuration;

namespace market
{
    class DBOperationsForSql
    {
        
        private string BaglantiDizesi;
        private static SqlConnection s_Baglanti;
        public SqlConnection Baglanti;
        private SqlCommand myCommand;

        public void DBOperationsForSqlServer(string server, string veritabani, string MysqlServerKullaniciAdi, bool yeni)
        {
            BaglantiDizesi = "Server=" + server + ";database=" + veritabani + "";
            BaglantiYap(BaglantiDizesi, yeni);
        }

        public void DBOperationsForSqlServer(string server, string veritabani, bool yeni)
        {
            BaglantiDizesi = "Server=" + server + ";database=" + veritabani + "";
            BaglantiYap(BaglantiDizesi, yeni);
        }

        public void DBOperationsForSqlServerFromAppConfig(bool yeni)
        {
            BaglantiDizesi = System.Configuration.ConfigurationManager.AppSettings["ConnStrBOAERP"];
            BaglantiYap(BaglantiDizesi, yeni);
        }

        private void BaglantiYap(string BaglantiDizesi, bool yeni)
        {
            try
            {
                if (yeni)
                {// yeni bağlantı olacak
                    Baglanti = new SqlConnection(BaglantiDizesi);
                }
                else
                { // yeni bağlantı olmayacak 
                    if (s_Baglanti == null) // static bağlantımız NULL ise tekrar set edilir.
                        s_Baglanti = new SqlConnection(BaglantiDizesi);

                    Baglanti = s_Baglanti;

                }

                myCommand = new SqlCommand();
                myCommand.Connection = Baglanti;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Baglan()
        {
            if (Baglanti.State == ConnectionState.Closed)
            {
                Baglanti.Open();
            }
        }

        public void BaglantiKes()
        {
            if (Baglanti.State == ConnectionState.Open)
            {
                Baglanti.Close();
            }
        }

        public void vtDegistir(string vt)
        {
            Baglanti.ChangeDatabase(vt);
        }

        public void transActionBaslat()
        {
            SqlTransaction transAction = Baglanti.BeginTransaction();
            myCommand.Transaction = transAction;
        }
        public void commit()
        {
            myCommand.Transaction.Commit();
        }
        public void rollback()
        {
            myCommand.Transaction.Rollback();
        }

        public DataTable TblGonder(string sqlCumlesi)
        {
            DataTable dt = null;
            SqlDataAdapter da = new SqlDataAdapter(sqlCumlesi, Baglanti);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int SqlExecute(string sqlCumlesi)
        {
            int etkilenenSatirSayisi = 0;
            myCommand = new SqlCommand();
            myCommand.Connection = Baglanti;
            myCommand.CommandText = sqlCumlesi;

            etkilenenSatirSayisi = myCommand.ExecuteNonQuery();

            return etkilenenSatirSayisi;
        }

        public int sqlKacKayitVar(string sqlCumlesi)
        {
            myCommand.CommandText = sqlCumlesi;
            return (int)myCommand.ExecuteScalar();
        }

        public object ExecuteScalar(string sqlCumlesi)
        {
            myCommand.CommandText = sqlCumlesi;
            return myCommand.ExecuteScalar();
          
        } 
    }
}
