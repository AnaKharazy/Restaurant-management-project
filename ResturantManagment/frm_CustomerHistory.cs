using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
/*
 Ana Kharazi
 Project for NazarAbad Azad University   
 Summer 1401/05/01
 Supervisor Mr.Minofam
*/
namespace RestaurantManagement
{
    public partial class frm_CustomerHistory : DevExpress.XtraEditors.XtraForm
    {
        public int CustomerID = 0;
        public frm_CustomerHistory(int _CustomerID)
        {
            InitializeComponent();
            CustomerID = _CustomerID;
            Load();
        }
        public int FactorID = -1;
        ResturantManagmentCore.Classes.frm_CustomersCore _CustomersCore = new ResturantManagmentCore.Classes.frm_CustomersCore();
        private void Load()
        {
            // fill CustomerFactorsHistory into DataSource 
            gcFactors.DataSource = _CustomersCore.CustomerFactorsHistory(CustomerID);           
        }
        private void gvFactors_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }
        private void btnShowFactor_Click_1(object sender, EventArgs e)
        {
            // Find CustomerFactorFile and Open it
            if (Convert.ToInt32(gvFactors.GetRowCellValue(gvFactors.FocusedRowHandle, colFactorID))!=0)
            {
                if (File.Exists($@"Factors\{Convert.ToInt32(gvFactors.GetRowCellValue(gvFactors.FocusedRowHandle, colFactorID))}.pdf"))
                {
                    System.Diagnostics.Process.Start($@"Factors\{Convert.ToInt32(gvFactors.GetRowCellValue(gvFactors.FocusedRowHandle, colFactorID))}.pdf");
                }                
            }
           
        }
    }
}