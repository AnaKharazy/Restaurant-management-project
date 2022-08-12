using RestaurantManagmentDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Classes
{
    public class frm_EmployeCore
    {
        RestaurantManagementEntities Context = new RestaurantManagementEntities();
        //this method return  EmployeeName from EmployeeID
        public string EmployeeName(int EmployeeID)
        {
            var Employee = Context.tbl_Employee.Find(EmployeeID);
            return Employee.FirstName + " " + Employee.LastName;
        }
        //this method shows if Employee is admin or not from EmployeeID
        public bool IsAdmin(int EmployeeID)
        {
            return Context.tbl_Employee.Where(a => a.EmployeeID == EmployeeID && a.IsAdmin == true).Any();
        }
        //this method Insert Employe 
        public bool InsertEmploye(tbl_Employee tbl_Employee)
        {
            try
            {

                Context.tbl_Employee.Add(tbl_Employee);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //this method Update Employee
        public bool UpdateEmployee(tbl_Employee tbl_Employee)
        {
            try
            {
                var emplo = Context.tbl_Employee.Find(tbl_Employee.EmployeeID);
                emplo.FirstName = tbl_Employee.FirstName;
                emplo.LastName = tbl_Employee.LastName;
                emplo.NationalId = tbl_Employee.NationalId;
                emplo.PhoneNumber = tbl_Employee.PhoneNumber;
                emplo.SexID = tbl_Employee.SexID;
                emplo.HomeAddress = tbl_Employee.HomeAddress;
                emplo.UserName = tbl_Employee.UserName;
                emplo.Password = Context.tbl_Employee.
                    Where(a => a.EmployeeID == tbl_Employee.EmployeeID)
                    .Where(a => a.Password == tbl_Employee.Password).Any()
                            == true ? tbl_Employee.Password : Utility.Utility.EncodePasswordMd5(tbl_Employee.Password);
                emplo.IsAdmin = tbl_Employee.IsAdmin;
                Context.Entry(emplo).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //this method return Employee List
        public List<Model.EmployeeModel> EmployeeModel(bool Active)
        {
            return Context.tbl_Employee.Where(a => a.Active == Active).Select(a => new Model.EmployeeModel
            {
                Active = a.Active,
                HomeAddress = a.HomeAddress,
                IsAdmin = a.IsAdmin,
                EmployeeID = a.EmployeeID,
                FirstName = a.FirstName,
                LastName = a.LastName,
                NationalId = a.NationalId,
                Password = a.Password,
                PhoneNumber = a.PhoneNumber,
                UserName = a.UserName,
                SexText = a.tbl_SexType.SexText
            }).ToList();
        }
        //this method return Find Employee 
        public tbl_Employee FindEmployee(int EmployeeID)
        {
            return Context.tbl_Employee.Where(a => a.EmployeeID == EmployeeID).FirstOrDefault();
        }
        //this method return gendre List
        public List<tbl_SexType> SexTypeList()
        {
            return Context.tbl_SexType.ToList();
        }
        //this method update and set Active or Deactive  to the Employee
        public bool ActiveDeactiveEmployee(int EmployeeID, bool ActiveStatus)
        {
            try
            {
                var Employee = Context.tbl_Employee.Find(EmployeeID);
                Employee.Active = ActiveStatus;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
