namespace RestaurantManagement
{
    partial class frm_FactorManagment
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty1 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty2 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty3 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty4 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty5 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty6 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty7 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty8 = new DevExpress.Data.UnboundSourceProperty();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFactorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderKindText = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcMain);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1565, 925);
            this.groupControl1.TabIndex = 0;
            // 
            // gcMain
            // 
            this.gcMain.ContextMenuStrip = this.Menu;
            this.gcMain.DataSource = this.unboundSource1;
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 2);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcMain.Size = new System.Drawing.Size(1561, 921);
            this.gcMain.TabIndex = 0;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFactor});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(174, 28);
            // 
            // btnFactor
            // 
            this.btnFactor.Name = "btnFactor";
            this.btnFactor.Size = new System.Drawing.Size(173, 24);
            this.btnFactor.Text = "مشاهده فاکتور";
            this.btnFactor.Click += new System.EventHandler(this.btnFactor_Click);
            // 
            // unboundSource1
            // 
            unboundSourceProperty1.DisplayName = null;
            unboundSourceProperty1.Name = "FactorID";
            unboundSourceProperty2.DisplayName = null;
            unboundSourceProperty2.Name = "SumFactor";
            unboundSourceProperty3.DisplayName = null;
            unboundSourceProperty3.Name = "Discount";
            unboundSourceProperty4.DisplayName = null;
            unboundSourceProperty4.Name = "OrderDate";
            unboundSourceProperty5.DisplayName = null;
            unboundSourceProperty5.Name = "EmployeeFullName";
            unboundSourceProperty6.DisplayName = null;
            unboundSourceProperty6.Name = "CustomerID";
            unboundSourceProperty7.DisplayName = null;
            unboundSourceProperty7.Name = "tax";
            unboundSourceProperty8.DisplayName = null;
            unboundSourceProperty8.Name = "OrderKindText";
            this.unboundSource1.Properties.Add(unboundSourceProperty1);
            this.unboundSource1.Properties.Add(unboundSourceProperty2);
            this.unboundSource1.Properties.Add(unboundSourceProperty3);
            this.unboundSource1.Properties.Add(unboundSourceProperty4);
            this.unboundSource1.Properties.Add(unboundSourceProperty5);
            this.unboundSource1.Properties.Add(unboundSourceProperty6);
            this.unboundSource1.Properties.Add(unboundSourceProperty7);
            this.unboundSource1.Properties.Add(unboundSourceProperty8);
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFactorID,
            this.colSumFactor,
            this.colDiscount,
            this.colOrderDate,
            this.colEmployeeFullName,
            this.colCustomerID,
            this.coltax,
            this.colOrderKindText});
            this.gvMain.GridControl = this.gcMain;
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsBehavior.Editable = false;
            this.gvMain.OptionsBehavior.ReadOnly = true;
            this.gvMain.OptionsMenu.EnableColumnMenu = false;
            this.gvMain.OptionsMenu.EnableFooterMenu = false;
            this.gvMain.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvMain.OptionsSelection.MultiSelect = true;
            this.gvMain.OptionsView.ShowGroupPanel = false;
            // 
            // colFactorID
            // 
            this.colFactorID.Caption = "کد فاکتور";
            this.colFactorID.FieldName = "FactorID";
            this.colFactorID.MinWidth = 25;
            this.colFactorID.Name = "colFactorID";
            this.colFactorID.Visible = true;
            this.colFactorID.VisibleIndex = 0;
            this.colFactorID.Width = 94;
            // 
            // colSumFactor
            // 
            this.colSumFactor.Caption = "جمع فاکتور";
            this.colSumFactor.FieldName = "SumFactor";
            this.colSumFactor.MinWidth = 25;
            this.colSumFactor.Name = "colSumFactor";
            this.colSumFactor.Visible = true;
            this.colSumFactor.VisibleIndex = 1;
            this.colSumFactor.Width = 94;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "تخفیف";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 25;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 2;
            this.colDiscount.Width = 94;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "تاریخ";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 25;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 3;
            this.colOrderDate.Width = 94;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.Caption = "نام کامل کارمند";
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.MinWidth = 25;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 4;
            this.colEmployeeFullName.Width = 94;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "کد اشتراک مشتری";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 5;
            this.colCustomerID.Width = 94;
            // 
            // coltax
            // 
            this.coltax.Caption = "مالیات";
            this.coltax.FieldName = "tax";
            this.coltax.MinWidth = 25;
            this.coltax.Name = "coltax";
            this.coltax.Visible = true;
            this.coltax.VisibleIndex = 6;
            this.coltax.Width = 94;
            // 
            // colOrderKindText
            // 
            this.colOrderKindText.Caption = "نوع سفارش";
            this.colOrderKindText.FieldName = "OrderKindText";
            this.colOrderKindText.MinWidth = 25;
            this.colOrderKindText.Name = "colOrderKindText";
            this.colOrderKindText.Visible = true;
            this.colOrderKindText.VisibleIndex = 7;
            this.colOrderKindText.Width = 94;
            // 
            // frm_FactorManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 925);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FactorManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.Data.UnboundSource unboundSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorID;
        private DevExpress.XtraGrid.Columns.GridColumn colSumFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn coltax;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderKindText;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem btnFactor;
    }
}