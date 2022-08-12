using DevExpress.XtraEditors;
using ResturantManagmentCore.Classes;
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
    public partial class frm_MangementEmployee : DevExpress.XtraEditors.XtraForm
    {
        public frm_MangementEmployee()
        {
            InitializeComponent();
            gcMain.DataSource = employeCore.EmployeeModel(true);
            Utility.FillToLookUpEdit("SexText", "SexID", cmbSex).Properties.DataSource = employeCore.SexTypeList();

        }
        frm_EmployeCore employeCore = new frm_EmployeCore();
        public int EmployeeID = -1;
        private void btnUpsert_Click(object sender, EventArgs e)
        {
            
            if (ValidationTextBox.Validate() == true)
            {
                if (EmployeeID == -1)
                {

                    employeCore.InsertEmploye(new RestaurantManagmentDataLayer.tbl_Employee
                    {
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        HomeAddress = txtAddresses.Text,
                        IsAdmin = chAdmin.Checked,
                        NationalId = txtNationalID.Text,
                        Password = Utility.EncodePasswordMd5(txtPassword.Text),
                        PhoneNumber = txtMobilePhone.Text,
                        SexID = Convert.ToInt32(cmbSex.EditValue),
                        Active = true,
                        UserName = txtUserName.Text
                    });
                    MessageBox.Show("با موفقیت ثبت شد");
                }
                else
                {
                    employeCore.UpdateEmployee(new RestaurantManagmentDataLayer.tbl_Employee
                    {
                        EmployeeID = EmployeeID,
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                        HomeAddress = txtAddresses.Text,
                        IsAdmin = chAdmin.Checked,
                        NationalId = txtNationalID.Text,
                        Password = txtPassword.Text,
                        PhoneNumber = txtMobilePhone.Text,
                        SexID = Convert.ToInt32(cmbSex.EditValue),
                        Active = true,
                        UserName = txtUserName.Text
                    });
                    MessageBox.Show("با موفقیت ویرایش شد");
                }
                btnUpsert.Text = "ثبت";
                btnReject.Visible = false;
                EmployeeID = -1;
                gcMain.DataSource = employeCore.EmployeeModel(true);
                //clear Component after Click on Update  and Insert
                foreach (Control item in groupInfo.Controls)
                {
                    if (item.GetType().Name == "TextEdit")
                    {
                        item.Text = null;
                    }
                    if (item.GetType().Name == "LookUpEdit")
                    {
                        LookUpEdit look = item as LookUpEdit;
                        look.EditValue = null;
                    }
                    if (item.GetType().Name == "CheckEdit")
                    {
                        CheckEdit look = item as CheckEdit;
                        look.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا تمام فیلد ها را کامل کنید");
            }
        }
        private void btnReject_Click(object sender, EventArgs e)
        {  //clear Component after Click on Reject
            foreach (Control item in groupInfo.Controls)
            {
                if (item.GetType().Name == "TextEdit")
                {
                    item.Text = null;
                }
                if (item.GetType().Name == "LookUpEdit")
                {
                    LookUpEdit look = item as LookUpEdit;
                    look.EditValue = null;
                }
                if (item.GetType().Name == "CheckEdit")
                {
                    CheckEdit look = item as CheckEdit;
                    look.Checked = false;
                }
            }
            btnUpsert.Text = "ثبت";
            btnReject.Visible = false;
            EmployeeID = -1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeID = Convert.ToInt32(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, colEmployeeID));
            var Employee = employeCore.FindEmployee(EmployeeID);
            txtAddresses.Text = Employee.HomeAddress;
            txtLastName.Text = Employee.LastName;
            txtMobilePhone.Text = Employee.PhoneNumber;
            txtName.Text = Employee.FirstName;
            txtNationalID.Text = Employee.NationalId;
            txtPassword.Text = Employee.Password;
            txtUserName.Text = Employee.UserName;
            chAdmin.Checked = Convert.ToBoolean(Employee.IsAdmin);
            cmbSex.EditValue = Employee.SexID;
            btnUpsert.Text = "ویرایش";
            btnReject.Visible = true;
        }
        private void btnDeataive_Click(object sender, EventArgs e)
        {
            employeCore.ActiveDeactiveEmployee(Convert.ToInt32(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, colEmployeeID)), false);
            gcMain.DataSource = employeCore.EmployeeModel(true);
        }
        private void btnActive_Click(object sender, EventArgs e)
        {
            employeCore.ActiveDeactiveEmployee(Convert.ToInt32(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, colEmployeeID)), true);
            gcMain.DataSource = employeCore.EmployeeModel(false);
        }

        private void btnActiveEmployeeList_Click(object sender, EventArgs e)
        {
            gcMain.DataSource = employeCore.EmployeeModel(true);
            btnActive.Visible = false;
        }

        private void btnDeactiveEmployeeList_Click(object sender, EventArgs e)
        {
            gcMain.DataSource = employeCore.EmployeeModel(false);
            btnActive.Visible = true;
        }

    }
}