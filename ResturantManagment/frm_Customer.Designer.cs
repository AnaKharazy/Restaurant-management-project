namespace ResturantManagment
{
    partial class frm_Customer
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
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty7 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty8 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty9 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty10 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty11 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty12 = new DevExpress.Data.UnboundSourceProperty();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcCustomer = new DevExpress.XtraGrid.GridControl();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerRegisterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcCustomer);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1267, 593);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // gcCustomer
            // 
            this.gcCustomer.DataSource = this.unboundSource1;
            this.gcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomer.Location = new System.Drawing.Point(2, 2);
            this.gcCustomer.MainView = this.gvCustomer;
            this.gcCustomer.Name = "gcCustomer";
            this.gcCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcCustomer.Size = new System.Drawing.Size(1263, 589);
            this.gcCustomer.TabIndex = 0;
            this.gcCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomer});
            // 
            // unboundSource1
            // 
            unboundSourceProperty7.DisplayName = null;
            unboundSourceProperty7.Name = "CustomerID";
            unboundSourceProperty8.DisplayName = null;
            unboundSourceProperty8.Name = "CustomerName";
            unboundSourceProperty9.DisplayName = null;
            unboundSourceProperty9.Name = "CustomerLastName";
            unboundSourceProperty10.DisplayName = null;
            unboundSourceProperty10.Name = "CustomerAddress";
            unboundSourceProperty11.DisplayName = null;
            unboundSourceProperty11.Name = "CustomerRegisterDate";
            unboundSourceProperty12.DisplayName = null;
            unboundSourceProperty12.Name = "CustomerPhoneNumber";
            this.unboundSource1.Properties.Add(unboundSourceProperty7);
            this.unboundSource1.Properties.Add(unboundSourceProperty8);
            this.unboundSource1.Properties.Add(unboundSourceProperty9);
            this.unboundSource1.Properties.Add(unboundSourceProperty10);
            this.unboundSource1.Properties.Add(unboundSourceProperty11);
            this.unboundSource1.Properties.Add(unboundSourceProperty12);
            // 
            // gvCustomer
            // 
            this.gvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCustomerName,
            this.colCustomerLastName,
            this.colCustomerAddress,
            this.colCustomerRegisterDate,
            this.colCustomerPhoneNumber});
            this.gvCustomer.GridControl = this.gcCustomer;
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.OptionsBehavior.Editable = false;
            this.gvCustomer.OptionsBehavior.ReadOnly = true;
            this.gvCustomer.OptionsMenu.EnableColumnMenu = false;
            this.gvCustomer.OptionsMenu.EnableFooterMenu = false;
            this.gvCustomer.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvCustomer.OptionsSelection.MultiSelect = true;
            this.gvCustomer.OptionsView.ShowGroupPanel = false;
            this.gvCustomer.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvCustomer_RowCellClick);
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "کد مشتری";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            this.colCustomerID.Width = 94;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "نام";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 94;
            // 
            // colCustomerLastName
            // 
            this.colCustomerLastName.Caption = "نام خانوادگی";
            this.colCustomerLastName.FieldName = "CustomerLastName";
            this.colCustomerLastName.MinWidth = 25;
            this.colCustomerLastName.Name = "colCustomerLastName";
            this.colCustomerLastName.Visible = true;
            this.colCustomerLastName.VisibleIndex = 2;
            this.colCustomerLastName.Width = 94;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.Caption = "آدرس";
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.MinWidth = 25;
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 3;
            this.colCustomerAddress.Width = 94;
            // 
            // colCustomerRegisterDate
            // 
            this.colCustomerRegisterDate.Caption = "تاریخ ثبت نام";
            this.colCustomerRegisterDate.FieldName = "CustomerRegisterDate";
            this.colCustomerRegisterDate.MinWidth = 25;
            this.colCustomerRegisterDate.Name = "colCustomerRegisterDate";
            this.colCustomerRegisterDate.Visible = true;
            this.colCustomerRegisterDate.VisibleIndex = 4;
            this.colCustomerRegisterDate.Width = 94;
            // 
            // colCustomerPhoneNumber
            // 
            this.colCustomerPhoneNumber.Caption = "تلفن همراه";
            this.colCustomerPhoneNumber.FieldName = "CustomerPhoneNumber";
            this.colCustomerPhoneNumber.MinWidth = 25;
            this.colCustomerPhoneNumber.Name = "colCustomerPhoneNumber";
            this.colCustomerPhoneNumber.Visible = true;
            this.colCustomerPhoneNumber.VisibleIndex = 5;
            this.colCustomerPhoneNumber.Width = 94;
            // 
            // frm_Customer
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 617);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.InactiveGlowColor = System.Drawing.Color.LightSeaGreen;
            this.Name = "frm_Customer";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcCustomer;
        private DevExpress.Data.UnboundSource unboundSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerRegisterDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhoneNumber;
    }
}