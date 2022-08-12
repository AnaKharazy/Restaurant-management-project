namespace RestaurantManagement
{
    partial class frm_Food
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
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty11 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty12 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty13 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty14 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty15 = new DevExpress.Data.UnboundSourceProperty();
            this.GroupInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnReject = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpsert = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_FoodDeatails = new DevExpress.XtraEditors.LookUpEdit();
            this.cmb_FoodType = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodPrice = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcFoods = new DevExpress.XtraGrid.GridControl();
            this.MenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActiveFoods = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeaActiveFoods = new System.Windows.Forms.ToolStripMenuItem();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.gvFoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoodText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoodTypeText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoodStausText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfo)).BeginInit();
            this.GroupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_FoodDeatails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_FoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFoods)).BeginInit();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupInfo
            // 
            this.GroupInfo.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.GroupInfo.Appearance.Options.UseBorderColor = true;
            this.GroupInfo.Controls.Add(this.btnReject);
            this.GroupInfo.Controls.Add(this.btnUpsert);
            this.GroupInfo.Controls.Add(this.labelControl4);
            this.GroupInfo.Controls.Add(this.labelControl3);
            this.GroupInfo.Controls.Add(this.cmb_FoodDeatails);
            this.GroupInfo.Controls.Add(this.cmb_FoodType);
            this.GroupInfo.Controls.Add(this.label2);
            this.GroupInfo.Controls.Add(this.txtFoodPrice);
            this.GroupInfo.Controls.Add(this.label1);
            this.GroupInfo.Controls.Add(this.txtFoodName);
            this.GroupInfo.Location = new System.Drawing.Point(12, 12);
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.Size = new System.Drawing.Size(891, 194);
            this.GroupInfo.TabIndex = 0;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(176, 136);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(94, 29);
            this.btnReject.TabIndex = 14;
            this.btnReject.Text = "انصراف";
            this.btnReject.Visible = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(21, 136);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(94, 29);
            this.btnUpsert.TabIndex = 13;
            this.btnUpsert.Text = "ثبت";
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(440, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 17);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "فهرست";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(834, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 17);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "نوع غذا";
            // 
            // cmb_FoodDeatails
            // 
            this.cmb_FoodDeatails.Location = new System.Drawing.Point(21, 98);
            this.cmb_FoodDeatails.Name = "cmb_FoodDeatails";
            this.cmb_FoodDeatails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_FoodDeatails.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FoodTypeID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FoodTypeText", "")});
            this.cmb_FoodDeatails.Properties.NullText = "";
            this.cmb_FoodDeatails.Size = new System.Drawing.Size(395, 22);
            this.cmb_FoodDeatails.TabIndex = 10;
            // 
            // cmb_FoodType
            // 
            this.cmb_FoodType.Location = new System.Drawing.Point(507, 98);
            this.cmb_FoodType.Name = "cmb_FoodType";
            this.cmb_FoodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_FoodType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FoodStatusID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FoodStausText", "")});
            this.cmb_FoodType.Properties.NullText = "";
            this.cmb_FoodType.Size = new System.Drawing.Size(301, 22);
            this.cmb_FoodType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "قیمت";
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(21, 55);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtFoodPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtFoodPrice.Size = new System.Drawing.Size(395, 22);
            this.txtFoodPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام غذا";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(507, 55);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(301, 22);
            this.txtFoodName.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcFoods);
            this.groupControl2.Location = new System.Drawing.Point(12, 212);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(891, 559);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // gcFoods
            // 
            this.gcFoods.ContextMenuStrip = this.MenuMain;
            this.gcFoods.DataSource = this.unboundSource1;
            this.gcFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFoods.Location = new System.Drawing.Point(2, 2);
            this.gcFoods.MainView = this.gvFoods;
            this.gcFoods.Name = "gcFoods";
            this.gcFoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcFoods.Size = new System.Drawing.Size(887, 555);
            this.gcFoods.TabIndex = 0;
            this.gcFoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFoods});
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnDelete,
            this.btnRestore,
            this.btnActiveFoods,
            this.btnDeaActiveFoods});
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(225, 124);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(224, 24);
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 24);
            this.btnDelete.Text = "غیر فعال سازی";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(224, 24);
            this.btnRestore.Text = "فعال سازی";
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnActiveFoods
            // 
            this.btnActiveFoods.Name = "btnActiveFoods";
            this.btnActiveFoods.Size = new System.Drawing.Size(224, 24);
            this.btnActiveFoods.Text = "لیست غذاهای فعال ";
            this.btnActiveFoods.Click += new System.EventHandler(this.btnActiveFoods_Click);
            // 
            // btnDeaActiveFoods
            // 
            this.btnDeaActiveFoods.Name = "btnDeaActiveFoods";
            this.btnDeaActiveFoods.Size = new System.Drawing.Size(224, 24);
            this.btnDeaActiveFoods.Text = "لیست غذاهای غیر فعال";
            this.btnDeaActiveFoods.Click += new System.EventHandler(this.btnDeaActiveFoods_Click);
            // 
            // unboundSource1
            // 
            unboundSourceProperty11.DisplayName = null;
            unboundSourceProperty11.Name = "FoodID";
            unboundSourceProperty12.DisplayName = null;
            unboundSourceProperty12.Name = "FoodText";
            unboundSourceProperty13.DisplayName = null;
            unboundSourceProperty13.Name = "Price";
            unboundSourceProperty14.DisplayName = null;
            unboundSourceProperty14.Name = "FoodTypeText";
            unboundSourceProperty15.DisplayName = null;
            unboundSourceProperty15.Name = "FoodStausText";
            this.unboundSource1.Properties.Add(unboundSourceProperty11);
            this.unboundSource1.Properties.Add(unboundSourceProperty12);
            this.unboundSource1.Properties.Add(unboundSourceProperty13);
            this.unboundSource1.Properties.Add(unboundSourceProperty14);
            this.unboundSource1.Properties.Add(unboundSourceProperty15);
            // 
            // gvFoods
            // 
            this.gvFoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFoodID,
            this.colFoodText,
            this.colPrice,
            this.colFoodTypeText,
            this.colFoodStausText});
            this.gvFoods.GridControl = this.gcFoods;
            this.gvFoods.Name = "gvFoods";
            this.gvFoods.OptionsBehavior.Editable = false;
            this.gvFoods.OptionsBehavior.ReadOnly = true;
            this.gvFoods.OptionsMenu.EnableColumnMenu = false;
            this.gvFoods.OptionsMenu.EnableFooterMenu = false;
            this.gvFoods.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvFoods.OptionsSelection.MultiSelect = true;
            this.gvFoods.OptionsView.ShowGroupPanel = false;
            // 
            // colFoodID
            // 
            this.colFoodID.Caption = "کد غذا";
            this.colFoodID.FieldName = "FoodID";
            this.colFoodID.MinWidth = 25;
            this.colFoodID.Name = "colFoodID";
            this.colFoodID.Visible = true;
            this.colFoodID.VisibleIndex = 0;
            this.colFoodID.Width = 94;
            // 
            // colFoodText
            // 
            this.colFoodText.Caption = "نام غذا";
            this.colFoodText.FieldName = "FoodText";
            this.colFoodText.MinWidth = 25;
            this.colFoodText.Name = "colFoodText";
            this.colFoodText.Visible = true;
            this.colFoodText.VisibleIndex = 1;
            this.colFoodText.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "قیمت";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 94;
            // 
            // colFoodTypeText
            // 
            this.colFoodTypeText.Caption = "فهرست";
            this.colFoodTypeText.FieldName = "FoodTypeText";
            this.colFoodTypeText.MinWidth = 25;
            this.colFoodTypeText.Name = "colFoodTypeText";
            this.colFoodTypeText.Visible = true;
            this.colFoodTypeText.VisibleIndex = 3;
            this.colFoodTypeText.Width = 94;
            // 
            // colFoodStausText
            // 
            this.colFoodStausText.Caption = "نوع غذا";
            this.colFoodStausText.FieldName = "FoodStausText";
            this.colFoodStausText.MinWidth = 25;
            this.colFoodStausText.Name = "colFoodStausText";
            this.colFoodStausText.Visible = true;
            this.colFoodStausText.VisibleIndex = 4;
            this.colFoodStausText.Width = 94;
            // 
            // frm_Food
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 783);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.GroupInfo);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Food";
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfo)).EndInit();
            this.GroupInfo.ResumeLayout(false);
            this.GroupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_FoodDeatails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_FoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFoods)).EndInit();
            this.MenuMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupInfo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtFoodPrice;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtFoodName;
        private DevExpress.XtraEditors.SimpleButton btnReject;
        private DevExpress.XtraEditors.SimpleButton btnUpsert;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmb_FoodDeatails;
        private DevExpress.XtraEditors.LookUpEdit cmb_FoodType;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcFoods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFoods;
        private DevExpress.Data.UnboundSource unboundSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripMenuItem btnActiveFoods;
        private System.Windows.Forms.ToolStripMenuItem btnDeaActiveFoods;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodID;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodText;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodTypeText;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodStausText;
    }
}