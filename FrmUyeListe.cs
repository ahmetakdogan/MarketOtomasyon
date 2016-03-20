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
    public partial class FrmUyeListe : baseForm
    {
        public FrmUyeListe()
        {
            InitializeComponent();
        }

        private void FrmUyeListe_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        public void uyeListele()
        {
            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.kullEkle", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            gridUye.DataSource = tablo;
        }

        public override void Kaydet()
        {
            MessageBox.Show(this.Text + " Formunda Kaydet komutu Çalıştı");
        }

        public override void Sil()
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();

            int uyeId = (int)gridViewUye.GetDataRow(gridViewUye.FocusedRowHandle)["id"];
            string uyeİsim = (string)gridViewUye.GetDataRow(gridViewUye.FocusedRowHandle)["kulAdi"];
            string SqlUyeSil = string.Format("delete from TST.kullEkle where id ={0}", uyeId);

            string UyariMsg = "" + uyeİsim + " isimli üyeyi silmek istediğinize emin misiniz?";
            DialogResult sonuc;
            sonuc = MessageBox.Show(UyariMsg, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                dbnesne.SqlExecute(SqlUyeSil);
                uyeListele();
            }
            else return;
            dbnesne.BaglantiKes();
        }

        private void FrmUyeListe_Activated(object sender, EventArgs e)
        {
            childForm = this; 
        }

        public override void Cikis()
        {
            this.Close();
        }
    }
}
