using RestaurantManagmentDataLayer;
using ResturantManagmentCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Classes
{
    public class frm_CustomersCore
    {
        RestaurantManagementEntities Context = new RestaurantManagementEntities();
        //this method return  active customer list 

        public List<tbl_Customer> CustomerList()
        {
            return Context.tbl_Customer.Where(a => a.Active == true).ToList();
        }
        //this method return  Deactive customer list 
        public List<tbl_Customer> CustomerListDactive()
        {
            return Context.tbl_Customer.Where(a => a.Active == false).ToList();
        }
        //this method Insert  customer  
        public bool InsertCustomer(tbl_Customer tbl_Customer)
        {
            try
            {
                Context.tbl_Customer.Add(tbl_Customer);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        //this method Find  customer  based on CustomerID
        public tbl_Customer FindCustomer(int CustomerID)
        {
            return Context.tbl_Customer.Find(CustomerID);
        }
        //this method Update  customer  based on CustomerID
        public bool UpdateCustomer(tbl_Customer Customer)
        {
            try
            {
                var customer = Context.tbl_Customer.Find(Customer.CustomerID);
                customer.CustomerAddress = Customer.CustomerAddress;
                customer.CustomerLastName = Customer.CustomerLastName;
                customer.CustomerName = Customer.CustomerName;
                customer.CustomerPhoneNumber = Customer.CustomerPhoneNumber;
                customer.CustomerRegisterDate = Customer.CustomerRegisterDate;
                Context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception E)
            {

                return false;
            }
        }
        //this method Delete  customer  based on CustomerID and ActiveStatus
        public bool DeleteCustomer(int CustomerID,bool ActiveStatus)
        {
            try
            {
                var Customer = Context.tbl_Customer.Find(CustomerID);
                Customer.Active= ActiveStatus;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //this method return factors CustomerHistory  
        private List<CustomerHistoryModel> CustomerHistoryModels(List<tbl_Factor> Factor)
        {
            RestaurantManagementEntities Context = new RestaurantManagementEntities();
            List<CustomerHistoryModel> CustomerHistoryModel = new List<CustomerHistoryModel>();
            List<tbl_Factor> Factors = Factor.ToList();
            foreach (var item in Factors)
            {
                CustomerHistoryModel.Add(new CustomerHistoryModel
                {
                    CustomerID = Convert.ToInt32(item.CustomerID),
                    Discount = Convert.ToDouble(item.Discount),
                    OrderDate = item.OrderDate,
                    FactorID = item.FactorID,
                    EmployeeFullName = Context.tbl_Employee.Where(a => a.EmployeeID == item.EmployeeID).FirstOrDefault().FirstName + " "
                    + Context.tbl_Employee.Where(a => a.EmployeeID == item.EmployeeID).FirstOrDefault().LastName,
                    OrderKindText = Context.tbl_OrderKind.Find(item.OrderKindID == null ? 1 : item.OrderKindID).OrderKindText,
                    SumFactor = Convert.ToDouble(item.SumFactor),
                    tax = Convert.ToDouble(item.tax),

                });
            };
            return  CustomerHistoryModel;
        }
        //this method return  CustomerHistoryFoodOrdered  
        private List<CustomerHistoryFoodOrderModel> CustomerHistoryFoodOrderModel(List<tbl_OrderFactor> tbl_OrderFactor)
        {
            RestaurantManagementEntities Context = new RestaurantManagementEntities();
            List<CustomerHistoryFoodOrderModel> OrderFoods = new List<CustomerHistoryFoodOrderModel>();
            List<tbl_OrderFactor> OrderFactor = tbl_OrderFactor.ToList();
            foreach (var item in OrderFactor)
            {
                OrderFoods.Add(new CustomerHistoryFoodOrderModel
                {
                    FoodCount = Convert.ToInt32(Context.tbl_Order.Where(a => a.OrderID == item.OrderID).FirstOrDefault().NumberFoodOrder),
                    FoodText = Context.tbl_Order.Find(item.OrderID).tbl_Food.FoodText,
                    Price = Convert.ToInt32(Context.tbl_Order.Find(item.OrderID).tbl_Food.Price),
                    FactorID = Convert.ToInt32(item.FactorID)
                });
            }
            return OrderFoods;
        }
        //this method return  tbl_OrderFactor as list  
        private List<tbl_OrderFactor> tbl_OrderFactors(List<tbl_Factor> Factor)
        {
            RestaurantManagementEntities Context = new RestaurantManagementEntities();
            List<tbl_OrderFactor> tbl_OrderFactors = new List<tbl_OrderFactor>();
            foreach (var item in Factor)
            {
                foreach (var Factors in Context.tbl_OrderFactor.Where(a => a.FactorID == item.FactorID).ToList())
                {
                    tbl_OrderFactors.Add(Context.tbl_OrderFactor.Where(a => a.FactorID == Factors.FactorID).FirstOrDefault());

                }
            }
            return tbl_OrderFactors;
        }
        //this method return  CustomerHistory as CustomerID  
        public List<CustomerHistoryModel> CustomerFactorsHistory(int CustomerID)
        {            
            var Factor = Context.tbl_Factor.Where(a => a.CustomerID == CustomerID).ToList();        
            return  CustomerHistoryModels(Factor);           
        }
        //this method return  CustomerHistoryFoodOrder from CustomerID  
        public List<CustomerHistoryFoodOrderModel> CustomerFactorFoodsDetailsHistory(int CustomerID)
        {
            var Factor = Context.tbl_Factor.Where(a => a.CustomerID == CustomerID).ToList();           
           return CustomerHistoryFoodOrderModel(tbl_OrderFactors(Factor));
        }
    }
}
