using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Model
{
    public class CustomerHistoryModel
    {    
        public int FactorID { get; set; }
        public double SumFactor { get; set; }
        public double Discount { get; set; }
        public string OrderDate { get; set; }
        public string EmployeeFullName { get; set; }
        public int? CustomerID { get; set; }
        public double tax { get; set; }
        public string OrderKindText { get; set; }
        
    }
    public class CustomerHistoryModelForReport
    {
        public List<CustomerHistoryModel> CustomerHistoryModel { get; set; }
        public List<CustomerHistoryFoodOrderModel> customerHistoryFoodOrders { get; set; }
    }
    public class CustomerHistoryFoodOrderModel
    {
        public int FactorID { get; set; }
        public string FoodText { get; set; }
        public int FoodCount { get; set; }
        public double Price { get; set; }
    }
}
