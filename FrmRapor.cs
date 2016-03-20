using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraEditors;

namespace market
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {

            this.reportV.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = dbnesne.Baglanti;
            komut.CommandText = "select * from TST.musteriler";
            komut.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
           
        }
    }
}
