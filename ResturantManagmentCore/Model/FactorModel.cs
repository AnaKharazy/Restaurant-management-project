using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Model
{
    public class FactorHistoryModel
    {

        public int FactorID { get; set; }
        public string SumFactor { get; set; }
        public string Discount { get; set; }
        public string OrderDate { get; set; }
        public string EmployeeFullName { get; set; }
        public int? CustomerID { get; set; }
        public string tax { get; set; }
        public string OrderKindText { get; set; }

    }
}
