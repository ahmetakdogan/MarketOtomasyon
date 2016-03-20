using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market
{
    public partial class FrmKullanıcı : baseForm
    {
        public FrmKullanıcı()
        {
            InitializeComponent();
        }

        private void FrmKullanıcı_MdiChildActivate(object sender, EventArgs e)
        {
            mainMdiForm frm = new mainMdiForm();
            frm.MdiParent = Program.owner;
            frm.Show();
        }

        private void btnKayd_Click(object sender, EventArgs e)
        {
            DBOperationsForSql dbnesne = new DBOperationsForSql();
            dbnesne.DBOperationsForSqlServerFromAppConfig(true);
            dbnesne.Baglan();

            if (!string.IsNullOrEmpty(txtAdi.Text) && !string.IsNullOrEmpty(txtKulSoy.Text) && !string.IsNullOrEmpty(txtKulAdi.Text) && !string.IsNullOrEmpty(txtKulPar.Text) && !string.IsNullOrEmpty(txtKulTel.Text))
            {

                Uyeler.yeniUye uye = new Uyeler.yeniUye();
                uye.adi = txtAdi.Text;
                uye.soyadi = txtKulSoy.Text;
                uye.kullan = txtKulAdi.Text;
                uye.parola = Md5Hash.MD5(txtKulPar.Text);
                uye.tel = txtKulTel.Text;
                uye.eposta = txtKulEpos.Text;
                uye.adres = txtKulAdr.Text;

                try
                {

                    Uyeler nsnUye = new Uyeler();
                    nsnUye.UyeEkle(uye);
                }
                catch (Exception ex)
                {
                    string Mesaj = "Hata Oluştu :" + ex.Message;
                }

                lblMesaj.Visible = true;
                
            }

            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            FrmKullanıcı frmKul = new FrmKullanıcı();
            frmKul.MdiParent = Program.owner;
            frmKul.Show();
            this.Close();
        }

        private void FrmKullanıcı_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        public override void Cikis()
        {
            this.Close();
        }

        private void FrmKullanıcı_Activated(object sender, EventArgs e)
        {
            childForm = this;
        }
    }
}
