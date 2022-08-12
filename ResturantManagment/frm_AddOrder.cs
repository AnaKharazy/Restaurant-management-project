using DevExpress.XtraEditors;
using RestaurantManagmentDataLayer;
using ResturantManagment;
using ResturantManagmentCore.Classes;
using ResturantManagmentCore.Model;
using ResturantManagmentCore.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class frm_AddOrder : DevExpress.XtraEditors.XtraForm
    {
        List<OrderModel> OrderModel = new List<OrderModel>();
        frm_AddOrderCore orderCore = new frm_AddOrderCore();
        public frm_AddOrder()
        {
            InitializeComponent();
            //this is for fill OrderKindList into cmbOrderKind
            Utility.FillToLookUpEdit("OrderKindText", "OrderKindID", cmbOrderKind).Properties.DataSource = orderCore.OrderKindList();
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {   // it open the CustomerForm For reciving customer data    
            frm_Customer frm = new frm_Customer();
            frm.ShowDialog();
            if (frm_Customer.CustomerID != -1)
            {
                var Customer = orderCore.FindCustomer(frm_Customer.CustomerID);
                if (Customer != null)
                {
                    txtCustomerName.Text = Customer.CustomerName;
                    txtCustomerFname.Text = Customer.CustomerLastName;
                    txtCustomerPhoneNumber.Text = Customer.CustomerPhoneNumber;
                }
            }
        }
        private void frm_AddOrder_Load(object sender, EventArgs e)
        {
            // Fills the food's list into the food's data Source 
            gcFoods.DataSource = orderCore.Foods();
        }
        private void gvFoods_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // when click on food's row add that food into the factors List
            if (OrderModel.Where(a => a.FoodID == Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID))).Any())
            {
                var FoodCount = OrderModel.Where(a => a.FoodID == Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID))).FirstOrDefault();
                FoodCount.FoodCount += 1;
                FoodCount.Price = Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colPrice)) * FoodCount.FoodCount;
            }
            else
            {
                OrderModel.Add(new OrderModel
                {
                    FoodID = Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID)),
                    FoodText = gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodText).ToString(),
                    Price = Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colPrice)),
                    FoodCount = 1
                });
            }
            gcFactors.DataSource = OrderModel;
            gcFactors.RefreshDataSource();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if (OrderModel.Count >= 1)
            {
                if (cmbOrderKind.Text != "" || frm_Customer.CustomerID != -1)
                {
                    List<int> OrdersID = orderCore.InsertIntoTblOrder(OrderModel);
                    int FactorID = orderCore.InsertIntoFactor(new tbl_Factor
                    {
                        CustomerID = frm_Customer.CustomerID,
                        OrderDate = Utility.GeorgianToPersian(DateTime.Now),
                        SumFactor = (OrderModel.Sum(a => a.Price) - Convert.ToDouble(txtDiscont.Text == "" ? "0" : txtDiscont.Text.Replace('.', '/'))).ToString(),
                        tax = (OrderModel.Sum(a => a.Price) * 0.09).ToString(),
                        EmployeeID = frm_Login.EmployeeID,
                        OrderKindID = Convert.ToInt32(cmbOrderKind.EditValue),
                        Discount = txtDiscont.Text == "" ? "0" : txtDiscont.Text

                    });
                    List<int> FactorOrderID = orderCore.InsertIntoFactorOrder(OrdersID, FactorID);
                    FactorRe factorRe = new FactorRe();
                    factorRe.DataSource = orderCore.FactorReport(FactorOrderID);
                    factorRe.ExportToPdf($@"Factors/{FactorID}.pdf");
                    System.Diagnostics.Process.Start($@"Factors\{FactorID}.pdf");
                    orderCore.UpdateFactorFile(FactorID, $@"Factors/{FactorID}.pdf");
                    OrderModel.Clear();
                    gcFactors.DataSource = null;
                    txtDiscont.Text = null;
                    cmbOrderKind.EditValue = null;
                    foreach (Control item in groupCustomerInformation.Controls)
                    {
                        if (item.GetType().Name == "TextEdit")
                        {
                            item.Text = null;
                        }

                    }
                }
                else
                {
                    MessageBox.Show(" نوع سفارش و مشتری را انتخاب کنید");
                }
            }
            else
            {
                MessageBox.Show("سفارشی انتخاب نشده است");
            }
        }

        private void gvFactors_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // when click on Factors's row remove that food from  factors List
            var foods = OrderModel.Where(a => a.FoodID == Convert.ToInt32(gvFactors.GetRowCellValue(gvFactors.FocusedRowHandle, colFoodID1))).FirstOrDefault();

            if (foods.FoodCount == 1)
            {
                OrderModel.Remove(foods);
            }
            else
            {
                double Price = (foods.Price / foods.FoodCount);
                foods.FoodCount -= 1;
                foods.Price = Price * foods.FoodCount;
            }
            gcFactors.DataSource = OrderModel;
            gcFactors.RefreshDataSource();
        }
    }
}