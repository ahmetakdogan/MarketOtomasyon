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
    public partial class mainMdiForm : baseForm
    {
        public mainMdiForm()
        {
            InitializeComponent();
        }

       
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmKullanıcı frmkull = new FrmKullanıcı();
            frmkull.MdiParent = Program.owner;
            frmkull.Show();
            mdıBar.Visible = true;
        }

        private void mainMdiForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Program.owner = this; //tüm program içinde owner formun bu form olduğunu belirtiyoruz.
        }

        private void btnÜrünEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmÜrünler frmÜ = new FrmÜrünler();
            frmÜ.Show();
            frmÜ.MdiParent = Program.owner;
            mdıBar.Visible = true;
        }

        private void btnKulList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmKullListe frmKull = new FrmKullListe();
            frmKull.MdiParent = Program.owner;
            frmKull.Show();
            mdıBar.Visible = true;
           
        }

        private void btnMüşList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmMüsterilerListesi frmMusteri = new FrmMüsterilerListesi();
            frmMusteri.MdiParent = Program.owner;
            frmMusteri.Show();
            mdıBar.Visible = true;
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmMusteriler frmMust = new FrmMusteriler();
            frmMust.MdiParent = Program.owner;
            frmMust.Show();
            mdıBar.Visible = true;
        }

        private void btnKulSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmUyeListe frmUye = new FrmUyeListe();
            frmUye.MdiParent = Program.owner;
            frmUye.Show();
            mdıBar.Visible = true;
        }

        private void btnÜrünSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmÜrünler frmÜrünSil = new FrmÜrünler();
            frmÜrünSil.MdiParent = Program.owner;
            frmÜrünSil.Show();
            mdıBar.Visible = true;
        }

        private void btnÜrünList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmÜrünler frmÜrünList = new FrmÜrünler();
            frmÜrünList.MdiParent = Program.owner;
            frmÜrünList.Show();
            mdıBar.Visible = true;
        }

        private void mdıBtnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            childForm.Kaydet();
        }

        private void mdıBtnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm.Sil();
        }

        private void mdıBtnCık_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            childForm.Cikis();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //Xrapor nsnRapor = new Xrapor();
            //DataTable tablo = new DataTable();
           
            //SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.musteriler", dbnesne.Baglanti);
            //dataAdap.Fill(tablo);
            //FrmMüsterilerListesi nsnMust = new FrmMüsterilerListesi();
            //nsnRapor.DataSource = tablo;
            //nsnRapor.ShowPreviewMarginLines = true;

            //nsnRapor.CreateDocument();

            //iTextSharp.text.Document raporPDF = new iTextSharp.text.Document();


            ////Xrapor nsnRapor = new Xrapor();
            //nsnRapor.rapor();
            //nsnRapor.ShowPreviewMarginLines = true;
            //nsnRapor.CreateDocument();

            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            Xrapor rapor = new Xrapor();
            DataTable tablo = new DataTable();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.musteriler", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            rapor.DataSource = tablo;
            //rapor.ShowPreview();
            
        }
    }
}
