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
    public partial class FrmÜrünler : baseForm
    {
        public FrmÜrünler()
        {
            InitializeComponent();
        }

        private void FrmÜrünler_MdiChildActivate(object sender, EventArgs e)
        {
            mainMdiForm frmÜ = new mainMdiForm();
            frmÜ.MdiParent = Program.owner;
            frmÜ.Show();
        }

        private void FrmÜrünler_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridÜrünList.Visible = false; 
            gridÜrün.Visible = true;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ürünListele();
            gridÜrünList.Visible = true;
            gridÜrün.Visible = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.ürünler", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            lblTopÜrün.Text = tablo.Rows.Count.ToString();
            lblÜrünTxt.Visible = true;
            lblTopÜrün.Visible = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridÜrünList.Visible = true;
            gridÜrün.Visible = false;
            ürünListele();
        }

        public void ürünListele()
        {
            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.ürünler", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            gridÜrünList.DataSource = tablo;
        }

        public override void Kaydet()
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            ürünler.yeniÜrün nsnÜrün = new ürünler.yeniÜrün();

            nsnÜrün.adi = gridView1.GetFocusedRowCellValue("ürünAdi").ToString();
            nsnÜrün.kod = gridView1.GetFocusedRowCellValue("ürünKodu").ToString();
            nsnÜrün.marka = gridView1.GetFocusedRowCellValue("marka").ToString();
            nsnÜrün.adet = gridView1.GetFocusedRowCellValue("adet").ToString();
            nsnÜrün.fiyat = gridView1.GetFocusedRowCellValue("fiyat").ToString();
            MessageBox.Show("Ürün Eklendi");

            ürünler ürün = new ürünler();
            ürün.ürünEkle(nsnÜrün);
        }

        public override void Sil()
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            int ürünId = (int)gridView2.GetDataRow(gridView2.FocusedRowHandle)["id"];
            string ürünİsim = (string)gridView2.GetDataRow(gridView2.FocusedRowHandle)["ürünAdi"];
            string SqlÜrünSil = string.Format("delete from TST.ürünler where id ={0}", ürünId);

            string UyariÜrünMsg = "" + ürünİsim + " adlı ürünü silmek istediğinize emin misiniz?";
            DialogResult sonuc;
            sonuc = MessageBox.Show(UyariÜrünMsg, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                dbnesne.SqlExecute(SqlÜrünSil);
                ürünListele();
            }
            else return;
            dbnesne.BaglantiKes();
        }

        public override void Cikis()
        {
            this.Close();
        }

        private void FrmÜrünler_Activated(object sender, EventArgs e)
        {
            childForm = this;
        }
    }
}
