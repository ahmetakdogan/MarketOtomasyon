namespace market
{
    partial class FrmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.gridMusteri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMustSoy = new DevExpress.XtraEditors.TextEdit();
            this.txtMustAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMustSoy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMustAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMusteri
            // 
            this.gridMusteri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMusteri.Location = new System.Drawing.Point(0, 88);
            this.gridMusteri.MainView = this.gridView1;
            this.gridMusteri.Name = "gridMusteri";
            this.gridMusteri.Size = new System.Drawing.Size(744, 392);
            this.gridMusteri.TabIndex = 5;
            this.gridMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridMusteri;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Adı";
            this.gridColumn1.FieldName = "adi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Soyadı";
            this.gridColumn2.FieldName = "soyadi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Meslek";
            this.gridColumn3.FieldName = "meslek";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Şehir";
            this.gridColumn4.FieldName = "sehir";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "TC NO";
            this.gridColumn5.FieldName = "TC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Adres";
            this.gridColumn6.FieldName = "adres";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // btnGeri
            // 
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.Location = new System.Drawing.Point(512, 38);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(66, 29);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(211, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Müşteri Soyadı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // txtMustSoy
            // 
            this.txtMustSoy.Location = new System.Drawing.Point(298, 41);
            this.txtMustSoy.Name = "txtMustSoy";
            this.txtMustSoy.Size = new System.Drawing.Size(100, 20);
            this.txtMustSoy.TabIndex = 15;
            // 
            // txtMustAdi
            // 
            this.txtMustAdi.Location = new System.Drawing.Point(74, 41);
            this.txtMustAdi.Name = "txtMustAdi";
            this.txtMustAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMustAdi.TabIndex = 14;
            // 
            // btnAra
            // 
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.Location = new System.Drawing.Point(431, 38);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 29);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 480);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMustSoy);
            this.Controls.Add(this.txtMustAdi);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.gridMusteri);
            this.Name = "FrmMusteriler";
            this.Text = "FrmMusteriler";
            this.Activated += new System.EventHandler(this.FrmMusteriler_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMustSoy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMustAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMustSoy;
        private DevExpress.XtraEditors.TextEdit txtMustAdi;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}