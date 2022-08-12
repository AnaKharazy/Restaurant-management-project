namespace RestaurantManagement
{
    partial class frm_FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FirstPage));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtActiveEmployee = new DevExpress.XtraBars.BarStaticItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnFactorManagment = new DevExpress.XtraBars.BarButtonItem();
            this.LabaleDate = new DevExpress.XtraBars.BarStaticItem();
            this.AddOrderPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAddOrder,
            this.barButtonItem1,
            this.btnAddFood,
            this.btnEmployee,
            this.barStaticItem1,
            this.txtActiveEmployee,
            this.btnLogin,
            this.btnFactorManagment,
            this.LabaleDate});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.AddOrderPage,
            this.ribbonPage1});
            this.ribbon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1544, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Caption = "                                                    ";
            this.btnAddOrder.Id = 1;
            this.btnAddOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.ImageOptions.Image")));
            this.btnAddOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.ImageOptions.LargeImage")));
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnAddOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddOrder_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "                                                     ";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Caption = "                                                           ";
            this.btnAddFood.Id = 3;
            this.btnAddFood.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnAddFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.ImageOptions.Image")));
            this.btnAddFood.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.ImageOptions.LargeImage")));
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddFood_ItemClick);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Caption = "                                                ";
            this.btnEmployee.Id = 4;
            this.btnEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.ImageOptions.Image")));
            this.btnEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.ImageOptions.LargeImage")));
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployee_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "کاربر فعال : ";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // txtActiveEmployee
            // 
            this.txtActiveEmployee.Id = 6;
            this.txtActiveEmployee.Name = "txtActiveEmployee";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "خروج";
            this.btnLogin.Hint = "صفحه لاگین";
            this.btnLogin.Id = 7;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnFactorManagment
            // 
            this.btnFactorManagment.Caption = "                                                       ";
            this.btnFactorManagment.Id = 8;
            this.btnFactorManagment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorManagment.ImageOptions.Image")));
            this.btnFactorManagment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFactorManagment.ImageOptions.LargeImage")));
            this.btnFactorManagment.Name = "btnFactorManagment";
            this.btnFactorManagment.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFactorManagment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFactorManagment_ItemClick);
            // 
            // LabaleDate
            // 
            this.LabaleDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.LabaleDate.Id = 9;
            this.LabaleDate.Name = "LabaleDate";
            // 
            // AddOrderPage
            // 
            this.AddOrderPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.AddOrderPage.Name = "AddOrderPage";
            this.AddOrderPage.Text = "ثبت سفارش";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddOrder);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ثبت سفارش";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "مدیریت مشتری";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAddFood);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ثبت غذا";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "مدیریت رستوران";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEmployee);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "مدیریت کاربران";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnFactorManagment);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "مدیریت فاکتور ها";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.txtActiveEmployee);
            this.ribbonStatusBar.ItemLinks.Add(this.LabaleDate);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 489);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1544, 30);
            // 
            // frm_FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 519);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frm_FirstPage";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "نرم افزار رستوران آنا و برادران بجز جمشیدشون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage AddOrderPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAddOrder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnAddFood;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnEmployee;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem txtActiveEmployee;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnFactorManagment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarStaticItem LabaleDate;
    }
}