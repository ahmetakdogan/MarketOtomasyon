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
    public partial class FrmKullListe : baseForm
    {
        public FrmKullListe()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeListe frmUyeList = new FrmUyeListe();
            frmUyeList.MdiParent = Program.owner;
            frmUyeList.Show();
        }

        private void FrmKullListe_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void ismeGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.kullEkle ORDER BY kulAdi", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            gridList.DataSource = tablo;
        }

        private void kayıtSırasınaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.kullEkle ORDER BY id", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            gridList.DataSource = tablo;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullanıcı frmEkle = new FrmKullanıcı();
            frmEkle.MdiParent = Program.owner;
            frmEkle.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void üyeSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();
            SqlDataAdapter dataAdap = new SqlDataAdapter("SELECT * FROM TST.kullEkle", dbnesne.Baglanti);
            dataAdap.Fill(tablo);
            lblSayi.Text = tablo.Rows.Count.ToString();
            lblText.Visible = true;
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hakkımızda birşey yok");
        }

        private void FrmKullListe_Activated(object sender, EventArgs e)
        {
            childForm = this;
        }

        public override void Cikis()
        {
            this.Close();
        }
    }
}
