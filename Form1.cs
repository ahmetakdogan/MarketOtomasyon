using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         DBOperationsForSql dbnesne = new DBOperationsForSql(); // bağlantı için

            DataTable tblUser = new DataTable();    // tablo için oluşturuldu.
            string Pass = Md5Hash.MD5(txtPass.Text);  // textboxa girilen parola verildi
            string UserSelect = string.Format("select * from TST.kullEkle where kullanici = '{0}' and kulParola = '{1}'"
                , txtUserName.Text   //   kullanıcı seçimi
                , Pass);

            dbnesne.DBOperationsForSqlServerFromAppConfig(true); // bağlantı için
            dbnesne.Baglan();                                   // bağlantı açıldı
            SqlCommand komut = new SqlCommand(UserSelect, dbnesne.Baglanti); // bağlantı ve kullanıcı stringi verildi.
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())    // veritabanında okuma yapıldı
            {
                string user_name = dr["kullanici"].ToString();
                string pass = dr["kulParola"].ToString();
                mainMdiForm mainMdi = new mainMdiForm();
                mainMdi.Show();     // bilgiler doğru ise anamenü açılır.
                this.Hide();        // bu form kapatılır.
            }

            else
            {
                MessageBox.Show("Login Bilgileri Hatalı!!!");
                return;
            }
        }

       
    }
}
