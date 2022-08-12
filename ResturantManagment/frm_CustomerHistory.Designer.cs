namespace RestaurantManagement
{
    partial class frm_CustomerHistory
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
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty12 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty13 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty14 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty15 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty16 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty17 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty18 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty19 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty20 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty21 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty22 = new DevExpress.Data.UnboundSourceProperty();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcFactors = new DevExpress.XtraGrid.GridControl();
            this.MenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.gvFactors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFactorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderKindText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unboundSource2 = new DevExpress.Data.UnboundSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFactors)).BeginInit();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.gcFactors);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1495, 686);
            this.groupControl1.TabIndex = 0;
            // 
            // gcFactors
            // 
            this.gcFactors.ContextMenuStrip = this.MenuMain;
            this.gcFactors.DataSource = this.unboundSource1;
            this.gcFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFactors.Location = new System.Drawing.Point(2, 28);
            this.gcFactors.MainView = this.gvFactors;
            this.gcFactors.Name = "gcFactors";
            this.gcFactors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcFactors.Size = new System.Drawing.Size(1491, 656);
            this.gcFactors.TabIndex = 0;
            this.gcFactors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFactors});
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowFactor});
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(170, 28);
            // 
            // btnShowFactor
            // 
            this.btnShowFactor.Name = "btnShowFactor";
            this.btnShowFactor.Size = new System.Drawing.Size(169, 24);
            this.btnShowFactor.Text = "مشاهده فکتور";
            this.btnShowFactor.Click += new System.EventHandler(this.btnShowFactor_Click_1);
            // 
            // unboundSource1
            // 
            unboundSourceProperty12.DisplayName = null;
            unboundSourceProperty12.Name = "FactorID";
            unboundSourceProperty13.DisplayName = null;
            unboundSourceProperty13.Name = "SumFactor";
            unboundSourceProperty14.DisplayName = null;
            unboundSourceProperty14.Name = "Discount";
            unboundSourceProperty15.DisplayName = null;
            unboundSourceProperty15.Name = "OrderDate";
            unboundSourceProperty16.DisplayName = null;
            unboundSourceProperty16.Name = "EmployeeFullName";
            unboundSourceProperty17.DisplayName = null;
            unboundSourceProperty17.Name = "CustomerID";
            unboundSourceProperty18.DisplayName = null;
            unboundSourceProperty18.Name = "tax";
            unboundSourceProperty19.DisplayName = null;
            unboundSourceProperty19.Name = "OrderKindText";
            this.unboundSource1.Properties.Add(unboundSourceProperty12);
            this.unboundSource1.Properties.Add(unboundSourceProperty13);
            this.unboundSource1.Properties.Add(unboundSourceProperty14);
            this.unboundSource1.Properties.Add(unboundSourceProperty15);
            this.unboundSource1.Properties.Add(unboundSourceProperty16);
            this.unboundSource1.Properties.Add(unboundSourceProperty17);
            this.unboundSource1.Properties.Add(unboundSourceProperty18);
            this.unboundSource1.Properties.Add(unboundSourceProperty19);
            // 
            // gvFactors
            // 
            this.gvFactors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFactorID,
            this.colSumFactor,
            this.colDiscount,
            this.colOrderDate,
            this.colEmployeeFullName,
            this.colCustomerID,
            this.coltax,
            this.colOrderKindText});
            this.gvFactors.GridControl = this.gcFactors;
            this.gvFactors.Name = "gvFactors";
            this.gvFactors.OptionsBehavior.Editable = false;
            this.gvFactors.OptionsBehavior.ReadOnly = true;
            this.gvFactors.OptionsMenu.EnableColumnMenu = false;
            this.gvFactors.OptionsMenu.EnableFooterMenu = false;
            this.gvFactors.OptionsSelection.MultiSelect = true;
            this.gvFactors.OptionsView.ShowGroupPanel = false;
            this.gvFactors.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvFactors_FocusedRowChanged);
            // 
            // colFactorID
            // 
            this.colFactorID.Caption = "شماره فاکتور";
            this.colFactorID.FieldName = "FactorID";
            this.colFactorID.MinWidth = 25;
            this.colFactorID.Name = "colFactorID";
            this.colFactorID.Visible = true;
            this.colFactorID.VisibleIndex = 0;
            this.colFactorID.Width = 94;
            // 
            // colSumFactor
            // 
            this.colSumFactor.Caption = "جمع";
            this.colSumFactor.FieldName = "SumFactor";
            this.colSumFactor.MinWidth = 25;
            this.colSumFactor.Name = "colSumFactor";
            this.colSumFactor.Visible = true;
            this.colSumFactor.VisibleIndex = 7;
            this.colSumFactor.Width = 94;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "تخفیف";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 25;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 5;
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
            this.colEmployeeFullName.Caption = "کارمند ثبت";
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.MinWidth = 25;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 4;
            this.colEmployeeFullName.Width = 94;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "کد مشتری";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 2;
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
            this.colOrderKindText.VisibleIndex = 1;
            this.colOrderKindText.Width = 94;
            // 
            // unboundSource2
            // 
            unboundSourceProperty20.DisplayName = null;
            unboundSourceProperty20.Name = "FoodText";
            unboundSourceProperty21.DisplayName = null;
            unboundSourceProperty21.Name = "FoodCount";
            unboundSourceProperty22.DisplayName = null;
            unboundSourceProperty22.Name = "Price";
            this.unboundSource2.Properties.Add(unboundSourceProperty20);
            this.unboundSource2.Properties.Add(unboundSourceProperty21);
            this.unboundSource2.Properties.Add(unboundSourceProperty22);
            // 
            // frm_CustomerHistory
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 686);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_CustomerHistory";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFactors)).EndInit();
            this.MenuMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcFactors;
        private DevExpress.Data.UnboundSource unboundSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFactors;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorID;
        private DevExpress.XtraGrid.Columns.GridColumn colSumFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn coltax;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderKindText;
        private DevExpress.Data.UnboundSource unboundSource2;
        private System.Windows.Forms.ContextMenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem btnShowFactor;
    }
}