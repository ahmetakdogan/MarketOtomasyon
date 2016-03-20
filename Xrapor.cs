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
    public partial class Xrapor : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrapor()
        {
            InitializeComponent();
        }


        public void rapor()
        {
            //Xrapor nsnRapor = new Xrapor();
            //DataTable tablo = new DataTable();
            //DBOperationsForSql dbnesne = new DBOperationsForSql();
            //dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            //dbnesne.Baglan();
            //SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.musteriler", dbnesne.Baglanti);
            //dataAdap.Fill(tablo);
            //FrmMüsterilerListesi nsnMust = new FrmMüsterilerListesi();
            //nsnRapor.DataSource = tablo;
            //nsnRapor.ShowPreviewMarginLines = true;
           
            //nsnRapor.CreateDocument();
           
        }
    }
}
