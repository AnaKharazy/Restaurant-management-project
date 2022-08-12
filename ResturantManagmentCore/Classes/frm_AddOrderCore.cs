using ResturantManagmentCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagmentDataLayer;

namespace ResturantManagmentCore.Classes
{
    public class frm_AddOrderCore
    {
        RestaurantManagementEntities Context = new RestaurantManagementEntities();
        //this method shows the foods that the user choose     
        public List<FoodsModel> Foods()
        {
            return Context.tbl_Food.Join(Context.tbl_FoodStatus, fo => fo.FoodStatusID, st => st.FoodStatusID, (fo, st)
                => new FoodsModel
                {
                    FoodID = fo.FoodID,
                    FoodStausText = fo.tbl_FoodStatus.FoodStausText,
                    FoodText = fo.FoodText,
                    Price = fo.Price,
                    FoodTypeText = fo.tbl_FoodType.FoodTypeText
                }).ToList();
        }
        //this method shows the order type
        public List<tbl_OrderKind> OrderKindList()
        {
            return Context.tbl_OrderKind.ToList();
        }
        //this method shows customer information based on customer ID
        public tbl_Customer FindCustomer(int CustomerID)
        {
            return Context.tbl_Customer.Find(CustomerID);
        }
        //this method update FactorAddress column after Factor inserted 
        public bool UpdateFactorFile(int FactorID,string FactorAddress)
        {
            try
            {
                var Factor = Context.tbl_Factor.Find(FactorID);
                Factor.PdfFileAddress = FactorAddress;
                Context.Entry(Factor).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        //this method insert in to the order table 
        //return the list of int which contain order's ID for when it wants to be inserted in FactorOrder table
        public List<int> InsertIntoTblOrder(List<OrderModel> orderModels)
        {
            List<int> OrdersID = new List<int>();
            foreach (var item in orderModels)
            {
                tbl_Order order = new tbl_Order();
                order.FoodID = item.FoodID;
                order.NumberFoodOrder = item.FoodCount;
                Context.tbl_Order.Add(order);
                Context.SaveChanges();
                OrdersID.Add(order.OrderID);
            }
            return OrdersID;
        }
        //this method inserted into the Factor table
        //return Factor ID
        public int InsertIntoFactor(tbl_Factor tbl_Factor)
        {
            tbl_Factor factor = new tbl_Factor();
            factor.CustomerID = tbl_Factor.CustomerID;
            factor.Discount = tbl_Factor.Discount;
            factor.EmployeeID = tbl_Factor.EmployeeID;
            factor.OrderDate = tbl_Factor.OrderDate;
            factor.OrderKindID = tbl_Factor.OrderKindID;
            factor.SumFactor = tbl_Factor.SumFactor;
            factor.tax = tbl_Factor.tax;
            Context.tbl_Factor.Add(factor);
            Context.SaveChanges();
            return factor.FactorID;
        }
        //this method inserted to the FactorOrder
        //return FactorOrderID
        public List<int> InsertIntoFactorOrder(List<int> OrdersID, int FactorsID)
        {
            List<int> FactorOrderID = new List<int>();
            try
            {
                tbl_OrderFactor tbl_OrderFactor = new tbl_OrderFactor();
                foreach (var item in OrdersID)
                {
                    tbl_OrderFactor.FactorID = FactorsID;
                    tbl_OrderFactor.OrderID = item;
                    Context.tbl_OrderFactor.Add(tbl_OrderFactor);
                    Context.SaveChanges();
                    FactorOrderID.Add(tbl_OrderFactor.OrderFactorID);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return FactorOrderID;
        }
        //this method return the FactroReportModel for Factor .pdf
        public List<FactroReportModel> FactorReport(List<int> FactorOrderID)
        {
            List<FactroReportModel> factroReportModels = new List<FactroReportModel>();
            List<tbl_OrderFactor> _OrderFactor = new List<tbl_OrderFactor>();
            List<tbl_Order> _Order = new List<tbl_Order>();
            tbl_Factor Factor = new tbl_Factor();
            foreach (var item in FactorOrderID)
            {
                _OrderFactor.Add(Context.tbl_OrderFactor.Where(a => a.OrderFactorID == item).FirstOrDefault());
            }            
            
            foreach (var item in _OrderFactor)
            {
                Factor = Context.tbl_Factor.Where(a => a.FactorID == item.FactorID).FirstOrDefault();
                _Order.Add(Context.tbl_Order.Where(a => a.OrderID == item.OrderID).FirstOrDefault());
            }            
            foreach (var item in _Order)
            {
                factroReportModels.Add(new FactroReportModel
                {
                    FactorID = Convert.ToInt32(Factor.FactorID),
                    FoodCount = Convert.ToInt32(item.NumberFoodOrder),
                    FoodText =Context.tbl_Food.Where(a=>a.FoodID==item.FoodID).FirstOrDefault().FoodText,
                    CustomerAddress = Factor.tbl_Customer.CustomerAddress,
                    CustomerFullNName = Factor.tbl_Customer.CustomerName + " " + Factor.tbl_Customer.CustomerLastName,
                    EmployeeFullName =Context.tbl_Employee.Where(a=>a.EmployeeID==Factor.EmployeeID).FirstOrDefault().FirstName+" "
                    + Context.tbl_Employee.Where(a => a.EmployeeID == Factor.EmployeeID).FirstOrDefault().LastName,
                    Discount = Convert.ToDouble(Factor.Discount.Replace('.', '/')),
                    SumFactor = Convert.ToDouble(Factor.SumFactor),
                    CustomerID = Convert.ToInt32(Factor.CustomerID),
                    CustomerPhoneNumber = Factor.tbl_Customer.CustomerPhoneNumber,
                    OrderDate = Factor.OrderDate,
                    OrderKindText = Factor.tbl_OrderKind.OrderKindText,
                    Price = Convert.ToDouble(Context.tbl_Food.Where(a => a.FoodID == item.FoodID).FirstOrDefault().Price) * Convert.ToInt32(item.NumberFoodOrder),
                    tax = Convert.ToDouble(Factor.tax)
                });

            }
            return factroReportModels;
        }
    }
}
