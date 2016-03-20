namespace market
{
    partial class FrmUyeListe
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
            this.gridUye = new DevExpress.XtraGrid.GridControl();
            this.gridViewUye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUye
            // 
            this.gridUye.Location = new System.Drawing.Point(0, -22);
            this.gridUye.MainView = this.gridViewUye;
            this.gridUye.Name = "gridUye";
            this.gridUye.Size = new System.Drawing.Size(722, 361);
            this.gridUye.TabIndex = 0;
            this.gridUye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUye});
            // 
            // gridViewUye
            // 
            this.gridViewUye.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridViewUye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridViewUye.GridControl = this.gridUye;
            this.gridViewUye.Name = "gridViewUye";
            this.gridViewUye.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewUye.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewUye.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewUye.OptionsSelection.MultiSelect = true;
            this.gridViewUye.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewUye.OptionsView.AllowCellMerge = true;
            this.gridViewUye.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewUye.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewUye.OptionsView.ShowAutoFilterRow = true;
            this.gridViewUye.OptionsView.ShowGroupedColumns = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Adı";
            this.gridColumn1.FieldName = "kulAdi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Soyadı";
            this.gridColumn2.FieldName = "kulSoyadi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Kullanıcı Adı";
            this.gridColumn3.FieldName = "kullanici";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Telefon";
            this.gridColumn4.FieldName = "kulTelefon";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "E posta";
            this.gridColumn5.FieldName = "kulEposta";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Adres";
            this.gridColumn6.FieldName = "kulAdres";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "id";
            this.gridColumn7.FieldName = "id";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridUye);
            this.panelControl1.Location = new System.Drawing.Point(3, 22);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(730, 339);
            this.panelControl1.TabIndex = 2;
            // 
            // FrmUyeListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(737, 377);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmUyeListe";
            this.Text = "FrmUyeListe";
            this.Activated += new System.EventHandler(this.FrmUyeListe_Activated);
            this.Load += new System.EventHandler(this.FrmUyeListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUye;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}