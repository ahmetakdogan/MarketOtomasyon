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
    public partial class FrmMüsterilerListesi : baseForm
    {
        public FrmMüsterilerListesi()
        {
            InitializeComponent();
        }

        private void FrmMüsterilerListesi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.musteriler", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            gridMusteri.DataSource = tablo;
        }

        private void FrmMüsterilerListesi_Activated(object sender, EventArgs e)
        {
            childForm = this;
        }

        public override void Cikis()
        {
            this.Close();
        }
    }
}
