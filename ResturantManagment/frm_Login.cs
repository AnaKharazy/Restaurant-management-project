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
namespace RestaurantManagement
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public static int EmployeeID = -1;
        public frm_Login()
        {
            InitializeComponent();
        }
       
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frm_LoginCore login = new frm_LoginCore();

            if (login.Login(txtPassword.Text,txtUserName.Text)!=-1)
            {
                EmployeeID = login.Login(txtPassword.Text, txtUserName.Text);
                frm_FirstPage frm_FirstPage = new frm_FirstPage();
                this.Hide();
                frm_FirstPage.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            }
        }
    }
}