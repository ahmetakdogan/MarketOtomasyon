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

namespace market
{
    public partial class FrmMusteriler : baseForm
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            gridMusteri.Visible = true;
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            string UserSelect = string.Format("select * from TST.musteriler where adi = '{0}' and soyadi = '{1}'"
               , txtMustAdi.Text
               , txtMustSoy.Text);

            DataTable tblMusteri = new DataTable();
            SqlDataAdapter dataAdap = new SqlDataAdapter(UserSelect, dbnesne.Baglanti);
            dataAdap.Fill(tblMusteri);

            gridMusteri.DataSource = tblMusteri;
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMusteriler_Activated(object sender, EventArgs e)
        {
            childForm = this;
        }

        public override void Cikis()
        {
            this.Close();
        }
    }
}
