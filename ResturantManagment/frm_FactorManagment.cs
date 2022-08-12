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
    public partial class frm_FactorManagment : DevExpress.XtraEditors.XtraForm
    {
        ResturantManagmentCore.Classes.frm_FactorManagmentCore factorManagmentCore = new ResturantManagmentCore.Classes.frm_FactorManagmentCore();
        public frm_FactorManagment()
        {
            InitializeComponent();
            gcMain.DataSource = factorManagmentCore.FactorHistory();
        }
        //Find CustomerFactorFile and Open it
        private void btnFactor_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, colFactorID)) != 0)
            {
                if (File.Exists($@"Factors\{Convert.ToInt32(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, colFactorID))}.pdf"))
                {
                    System.Diagnostics.Process.Start($@"Factors\{Convert.ToInt32(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, colFactorID))}.pdf");
                }
                else
                {
                    MessageBox.Show("فایل فاکتور وجود ندارد");
                }
            }
        }
    }
}