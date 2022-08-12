using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Model
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string SexText { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
