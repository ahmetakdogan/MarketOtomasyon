namespace market
{
    partial class FrmKullListe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ismeGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSırasınaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            this.lblSayı = new DevExpress.XtraEditors.LabelControl();
            this.lblSayi = new DevExpress.XtraEditors.LabelControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyelerToolStripMenuItem,
            this.üyeSayısıToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeListeleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.üyelerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // üyeListeleToolStripMenuItem
            // 
            this.üyeListeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ismeGöreToolStripMenuItem,
            this.kayıtSırasınaGöreToolStripMenuItem});
            this.üyeListeleToolStripMenuItem.Name = "üyeListeleToolStripMenuItem";
            this.üyeListeleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.üyeListeleToolStripMenuItem.Text = "Üye listele";
            // 
            // ismeGöreToolStripMenuItem
            // 
            this.ismeGöreToolStripMenuItem.Name = "ismeGöreToolStripMenuItem";
            this.ismeGöreToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ismeGöreToolStripMenuItem.Text = "isme göre";
            this.ismeGöreToolStripMenuItem.Click += new System.EventHandler(this.ismeGöreToolStripMenuItem_Click);
            // 
            // kayıtSırasınaGöreToolStripMenuItem
            // 
            this.kayıtSırasınaGöreToolStripMenuItem.Name = "kayıtSırasınaGöreToolStripMenuItem";
            this.kayıtSırasınaGöreToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kayıtSırasınaGöreToolStripMenuItem.Text = "kayıt sırasına göre";
            this.kayıtSırasınaGöreToolStripMenuItem.Click += new System.EventHandler(this.kayıtSırasınaGöreToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Ekle";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ekleToolStripMenuItem.Text = "Sil";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // üyeSayısıToolStripMenuItem
            // 
            this.üyeSayısıToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.üyeSayısıToolStripMenuItem.Name = "üyeSayısıToolStripMenuItem";
            this.üyeSayısıToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.üyeSayısıToolStripMenuItem.Text = "Üye sayısı";
            this.üyeSayısıToolStripMenuItem.Click += new System.EventHandler(this.üyeSayısıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // gridList
            // 
            this.gridList.Location = new System.Drawing.Point(0, 55);
            this.gridList.MainView = this.gridView1;
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(658, 198);
            this.gridList.TabIndex = 1;
            this.gridList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridList;
            this.gridView1.Name = "gridView1";
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(12, 283);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(89, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Kayıtlı üye sayısı =";
            this.lblText.Visible = false;
            // 
            // lblSayı
            // 
            this.lblSayı.Location = new System.Drawing.Point(107, 283);
            this.lblSayı.Name = "lblSayı";
            this.lblSayı.Size = new System.Drawing.Size(0, 13);
            this.lblSayı.TabIndex = 3;
            // 
            // lblSayi
            // 
            this.lblSayi.Location = new System.Drawing.Point(108, 283);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(0, 13);
            this.lblSayi.TabIndex = 4;
            // 
            // FrmKullListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(658, 362);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblSayı);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmKullListe";
            this.Text = "FrmKullListe";
            this.Activated += new System.EventHandler(this.FrmKullListe_Activated);
            this.MdiChildActivate += new System.EventHandler(this.FrmKullListe_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ismeGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSırasınaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblText;
        private DevExpress.XtraEditors.LabelControl lblSayı;
        private DevExpress.XtraEditors.LabelControl lblSayi;

    }
}