using RestaurantManagmentDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Classes
{
    public class frm_FactorManagmentCore
    {
        //this method return FactorHistory as list
        public List<Model.FactorHistoryModel> FactorHistory()
        {
            RestaurantManagementEntities Context = new RestaurantManagementEntities();
           
            return Context.tbl_Factor.Select(a => new Model.FactorHistoryModel
            {
                CustomerID = a.CustomerID,
                Discount = a.Discount,
                OrderDate = a.OrderDate,
                FactorID = a.FactorID,
                EmployeeFullName = Context.tbl_Employee.Where(e => e.EmployeeID == a.EmployeeID).FirstOrDefault().FirstName + " "
                 + Context.tbl_Employee.Where(e => e.EmployeeID == a.EmployeeID).FirstOrDefault().LastName,
                OrderKindText = Context.tbl_OrderKind.Where(O => O.OrderKindID == a.OrderKindID).FirstOrDefault().OrderKindText,
                SumFactor = a.SumFactor,
                tax = a.tax
            }).ToList();
        }
    }
}
