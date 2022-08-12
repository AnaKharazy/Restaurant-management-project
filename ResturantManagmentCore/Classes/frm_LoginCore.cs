using RestaurantManagmentDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Classes
{
    public class frm_LoginCore
    {
        RestaurantManagementEntities Context = new RestaurantManagementEntities();

        //this method validation user Login 
        public int Login(string Password, string UserName)
        {
            Password = Utility.Utility.EncodePasswordMd5(Password);
            if (Context.tbl_Employee.Where(a => a.UserName == UserName && a.Password == Password).Any())
            {
                return Context.tbl_Employee.Where(a => a.UserName == UserName && a.Password == Password).FirstOrDefault().EmployeeID;
            }
            else
            {
                return -1;
            }

        }
    }
}
