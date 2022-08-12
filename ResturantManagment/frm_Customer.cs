using DevExpress.XtraEditors;
using ResturantManagmentCore.Classes;
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
namespace ResturantManagment
{
    public partial class frm_Customer : DevExpress.XtraEditors.XtraForm
    {
        public static int CustomerID=-1;
        frm_CustomersCore Customer = new frm_CustomersCore();
        public frm_Customer()
        {
            InitializeComponent();
            gcCustomer.DataSource = Customer.CustomerList();
            
        }
        // when click on Customer's row  fill CustomerID With focuse CustomerID
        private void gvCustomer_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            CustomerID = Convert.ToInt32(gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, colCustomerID));
            this.Close();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}