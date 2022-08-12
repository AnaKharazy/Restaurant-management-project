using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ResturantManagmentCore.Classes;
using RestaurantManagmentDataLayer;
/*
 Ana Kharazi
 Project for NazarAbad Azad University   
 Summer 1401/05/01
 Supervisor Mr.Minofam
*/
namespace RestaurantManagement
{
    public partial class frm_AddNewCustomer : DevExpress.XtraEditors.XtraForm
    {
        int CustomerID = -1;
        public frm_AddNewCustomer()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            //this is for Load CustomerList
            gcCustomer.DataSource = customerCore.CustomerList();
        }
        frm_CustomersCore customerCore = new frm_CustomersCore();
        private void btnUpsert_Click(object sender, EventArgs e)
        {   //this is for Validate CustomerModel
            if (ValidationProviderTextBOX.Validate() == true)
            {
                if (CustomerID == -1)
                {
                    customerCore.InsertCustomer(new tbl_Customer
                    {
                        CustomerAddress = txtAdress.Text,
                        CustomerLastName = txtFname.Text,
                        CustomerPhoneNumber = txtPhoneNumber.Text,
                        CustomerName = txtName.Text,
                        CustomerRegisterDate = txtRegesterDate.Text,
                        Active = true
                    });
                    MessageBox.Show("با موفقیت ثبت شد");
                }
                else
                {

                    customerCore.UpdateCustomer(new tbl_Customer
                    {
                        CustomerID = CustomerID,
                        CustomerAddress = txtAdress.Text,
                        CustomerLastName = txtFname.Text,
                        CustomerPhoneNumber = txtPhoneNumber.Text,
                        CustomerName = txtName.Text,
                        CustomerRegisterDate = txtRegesterDate.Text,
                        Active = true
                    });
                    MessageBox.Show("با موفقیت ویرایش شد");
                }
                //this is for clear components 
                foreach (Control item in groupControl1.Controls)
                {
                    string name = item.GetType().Name;
                    if (item.GetType().Name == "TextEdit")
                    {
                        item.Text = null;
                    }
                }
                CustomerID = -1;
                btnReject.Visible = false;
                btnUpsert.Text = "ثبت";
                Load();
            }
            else
            {
                MessageBox.Show("لطفا تمام فیلد ها را کامل نمایید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            var Customer = customerCore.FindCustomer(Convert.ToInt32(gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, colCustomerID)));
            txtAdress.Text = Customer.CustomerAddress;
            txtFname.Text = Customer.CustomerLastName;
            txtName.Text = Customer.CustomerName;
            txtPhoneNumber.Text = Customer.CustomerPhoneNumber;
            txtRegesterDate.Text = Customer.CustomerRegisterDate;
            CustomerID = Customer.CustomerID;
            btnUpsert.Text = "ویرایش";
            btnReject.Visible = true;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            customerCore.DeleteCustomer(Convert.ToInt32(gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, colCustomerID)), false);
            Load();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            //this is for clear components 
            foreach (Control item in groupControl1.Controls)
            {
                string name = item.GetType().Name;
                if (item.GetType().Name == "TextEdit")
                {
                    item.Text = null;
                }
            }
            CustomerID = -1;
            btnReject.Visible = false;
            btnUpsert.Text = "ثبت";
        }

        private void btnCustomerHistory_Click(object sender, EventArgs e)
        {
            //open CustomerHistory Form and send Variable with Constructor to the form class
            frm_CustomerHistory frm_Customer = new frm_CustomerHistory(Convert.ToInt32(gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, colCustomerID)));
            frm_Customer.ShowDialog();
        }

        private void btnDactiveCus_Click(object sender, EventArgs e)
        {
            gcCustomer.DataSource = customerCore.CustomerListDactive();
            btnRestore.Visible = true;
        }

        private void btnActivrCus_Click(object sender, EventArgs e)
        {
            btnRestore.Visible = false;
            Load();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            customerCore.DeleteCustomer(Convert.ToInt32(gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, colCustomerID)), true);
            gcCustomer.DataSource = customerCore.CustomerListDactive();
        }

        private void gcCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}