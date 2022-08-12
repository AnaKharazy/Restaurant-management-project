using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Model
{
    public class FoodsModel
    {
        public int FoodID { get; set; }
        public string FoodText { get; set; }
        public string Price { get; set; }
        public string FoodTypeText { get; set; }
        public string FoodStausText { get; set; }

    }
    public class OrderModel
    {
        public int FoodID { get; set; }
        public string FoodText { get; set; }
        public int FoodCount { get; set; }
        public double Price { get; set; }
    }
    public class CustomerForOrder
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
    }
    public class FactroReportModel
    {
        public string FoodText { get; set; }
        public int FoodCount { get; set; }
        public double Price { get; set; }
        public int FactorID { get; set; }
        public string CustomerFullNName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public double SumFactor { get; set; }
        public double Discount { get; set; }
        public string OrderDate { get; set; }
        public string EmployeeFullName { get; set; }
        public int CustomerID { get; set; }
        public double tax { get; set; }
        public string OrderKindText { get; set; }

    }
}
