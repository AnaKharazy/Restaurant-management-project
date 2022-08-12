namespace RestaurantManagement
{
    partial class frm_AddNewCustomer
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty1 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty2 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty3 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty4 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty5 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty6 = new DevExpress.Data.UnboundSourceProperty();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAdress = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtFname = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtRegesterDate = new DevExpress.XtraEditors.TextEdit();
            this.btnReject = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpsert = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labalName = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcCustomer = new DevExpress.XtraGrid.GridControl();
            this.MenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDactiveCus = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivrCus = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerRegisterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValidationProviderTextBOX = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegesterDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).BeginInit();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProviderTextBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.txtAdress);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtFname);
            this.groupControl1.Controls.Add(this.txtPhoneNumber);
            this.groupControl1.Controls.Add(this.txtRegesterDate);
            this.groupControl1.Controls.Add(this.btnReject);
            this.groupControl1.Controls.Add(this.btnUpsert);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.labalName);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(1864, 144);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "اطلاعات مشتری";
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdress.Location = new System.Drawing.Point(422, 101);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(1316, 22);
            this.txtAdress.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "نمیتواند خالی باشد";
            this.ValidationProviderTextBOX.SetValidationRule(this.txtAdress, conditionValidationRule1);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(1529, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 22);
            this.txtName.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "نمیتواند خالی باشد";
            this.ValidationProviderTextBOX.SetValidationRule(this.txtName, conditionValidationRule2);
            // 
            // txtFname
            // 
            this.txtFname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFname.Location = new System.Drawing.Point(1049, 49);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(286, 22);
            this.txtFname.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "نمیتواند خالی باشد";
            this.ValidationProviderTextBOX.SetValidationRule(this.txtFname, conditionValidationRule3);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(642, 47);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtPhoneNumber.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtPhoneNumber.Properties.MaskSettings.Set("mask", "\\0\\9000000000");
            this.txtPhoneNumber.Size = new System.Drawing.Size(199, 22);
            this.txtPhoneNumber.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "نمیتواند خالی باشد";
            this.ValidationProviderTextBOX.SetValidationRule(this.txtPhoneNumber, conditionValidationRule4);
            // 
            // txtRegesterDate
            // 
            this.txtRegesterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegesterDate.Location = new System.Drawing.Point(222, 47);
            this.txtRegesterDate.Name = "txtRegesterDate";
            this.txtRegesterDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtRegesterDate.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtRegesterDate.Properties.MaskSettings.Set("mask", "0000/00/00");
            this.txtRegesterDate.Size = new System.Drawing.Size(183, 22);
            this.txtRegesterDate.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "نمیتواند خالی باشد";
            this.ValidationProviderTextBOX.SetValidationRule(this.txtRegesterDate, conditionValidationRule5);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Location = new System.Drawing.Point(322, 96);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(94, 31);
            this.btnReject.TabIndex = 11;
            this.btnReject.Text = "انصراف";
            this.btnReject.Visible = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnUpsert
            // 
            this.btnUpsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpsert.Location = new System.Drawing.Point(222, 96);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(94, 31);
            this.btnUpsert.TabIndex = 5;
            this.btnUpsert.Text = "ثبت";
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "تاریخ ثبت نام";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "تلفن همراه";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1786, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "آدرس";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1373, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // labalName
            // 
            this.labalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labalName.AutoSize = true;
            this.labalName.Location = new System.Drawing.Point(1786, 54);
            this.labalName.Name = "labalName";
            this.labalName.Size = new System.Drawing.Size(24, 17);
            this.labalName.TabIndex = 1;
            this.labalName.Text = "نام";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gcCustomer);
            this.groupControl2.Location = new System.Drawing.Point(12, 162);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1864, 755);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // gcCustomer
            // 
            this.gcCustomer.ContextMenuStrip = this.MenuMain;
            this.gcCustomer.DataSource = this.unboundSource1;
            this.gcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomer.Location = new System.Drawing.Point(2, 2);
            this.gcCustomer.MainView = this.gvCustomer;
            this.gcCustomer.Name = "gcCustomer";
            this.gcCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcCustomer.Size = new System.Drawing.Size(1860, 751);
            this.gcCustomer.TabIndex = 0;
            this.gcCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomer});
            this.gcCustomer.Click += new System.EventHandler(this.gcCustomer_Click);
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnRemove,
            this.btnCustomerHistory,
            this.btnDactiveCus,
            this.btnActivrCus,
            this.btnRestore});
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuMain.Size = new System.Drawing.Size(191, 148);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 24);
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(190, 24);
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCustomerHistory
            // 
            this.btnCustomerHistory.Name = "btnCustomerHistory";
            this.btnCustomerHistory.Size = new System.Drawing.Size(190, 24);
            this.btnCustomerHistory.Text = "مشاهده سوابق";
            this.btnCustomerHistory.Click += new System.EventHandler(this.btnCustomerHistory_Click);
            // 
            // btnDactiveCus
            // 
            this.btnDactiveCus.Name = "btnDactiveCus";
            this.btnDactiveCus.Size = new System.Drawing.Size(190, 24);
            this.btnDactiveCus.Text = "مشتری حذف شده";
            this.btnDactiveCus.Click += new System.EventHandler(this.btnDactiveCus_Click);
            // 
            // btnActivrCus
            // 
            this.btnActivrCus.Name = "btnActivrCus";
            this.btnActivrCus.Size = new System.Drawing.Size(190, 24);
            this.btnActivrCus.Text = "لیست اصلی";
            this.btnActivrCus.Click += new System.EventHandler(this.btnActivrCus_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(190, 24);
            this.btnRestore.Text = "بازیابی";
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // unboundSource1
            // 
            unboundSourceProperty1.DisplayName = null;
            unboundSourceProperty1.Name = "CustomerID";
            unboundSourceProperty2.DisplayName = null;
            unboundSourceProperty2.Name = "CustomerName";
            unboundSourceProperty3.DisplayName = null;
            unboundSourceProperty3.Name = "CustomerLastName";
            unboundSourceProperty4.DisplayName = null;
            unboundSourceProperty4.Name = "CustomerAddress";
            unboundSourceProperty5.DisplayName = null;
            unboundSourceProperty5.Name = "CustomerRegisterDate";
            unboundSourceProperty6.DisplayName = null;
            unboundSourceProperty6.Name = "CustomerPhoneNumber";
            this.unboundSource1.Properties.Add(unboundSourceProperty1);
            this.unboundSource1.Properties.Add(unboundSourceProperty2);
            this.unboundSource1.Properties.Add(unboundSourceProperty3);
            this.unboundSource1.Properties.Add(unboundSourceProperty4);
            this.unboundSource1.Properties.Add(unboundSourceProperty5);
            this.unboundSource1.Properties.Add(unboundSourceProperty6);
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
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "کد اشتراک";
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
            // frm_AddNewCustomer
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 929);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.Name = "frm_AddNewCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_AddNewCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegesterDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).EndInit();
            this.MenuMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProviderTextBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcCustomer;
        private DevExpress.XtraEditors.SimpleButton btnUpsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labalName;
        private DevExpress.Data.UnboundSource unboundSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerRegisterDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhoneNumber;
        private System.Windows.Forms.ContextMenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnRemove;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
        private DevExpress.XtraEditors.SimpleButton btnReject;
        private System.Windows.Forms.ToolStripMenuItem btnCustomerHistory;
        private DevExpress.XtraEditors.TextEdit txtRegesterDate;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtFname;
        private DevExpress.XtraEditors.TextEdit txtAdress;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.ToolStripMenuItem btnDactiveCus;
        private System.Windows.Forms.ToolStripMenuItem btnActivrCus;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProviderTextBOX;
    }
}