using DevExpress.XtraBars;
using ResturantManagmentCore.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Ana Kharazi
 Project for NazarAbad Azad University   
 Summer 1401/05/01
 Supervisor Mr.Minofam
*/
namespace RestaurantManagement
{
    public partial class frm_FirstPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ResturantManagmentCore.Classes.frm_EmployeCore _EmployeCore = new ResturantManagmentCore.Classes.frm_EmployeCore();
        public frm_FirstPage()
        {

            InitializeComponent();
            // Validiate for Admin Access
            if (_EmployeCore.IsAdmin(frm_Login.EmployeeID))
            {
                btnEmployee.Enabled = true;
                btnFactorManagment.Enabled = true;
            }
            else
            {
                btnEmployee.Enabled = false;
                btnFactorManagment.Enabled = false;
            }
            //Fill active Employee  Name 
            txtActiveEmployee.Caption = _EmployeCore.EmployeeName(frm_Login.EmployeeID);
            //Fill current Date 
            LabaleDate.Caption = Utility.GeorgianToPersian(DateTime.Now);
        }

        private void btnAddOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_AddOrder frm = new frm_AddOrder();
            frm.MdiParent = frm_FirstPage.ActiveForm;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_AddNewCustomer frm = new frm_AddNewCustomer();
            frm.MdiParent = frm_FirstPage.ActiveForm;
            frm.Show();
        }

        private void btnAddFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Food f = new frm_Food();
            f.ShowDialog();
        }

        private void btnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_MangementEmployee frm = new frm_MangementEmployee();
            frm.MdiParent = frm_FirstPage.ActiveForm;
            frm.Show();
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Login l = new frm_Login();
            l.Show();
            frm_Login.EmployeeID = -1;
            this.Hide();
        }

        private void btnFactorManagment_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_FactorManagment frm = new frm_FactorManagment();
            frm.MdiParent = frm_FirstPage.ActiveForm;
            frm.Show();
        }
    }
}