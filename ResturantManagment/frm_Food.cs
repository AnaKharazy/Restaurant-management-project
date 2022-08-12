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
using ResturantManagmentCore.Classes;
using ResturantManagmentCore.Utility;
/*
 Ana Kharazi
 Project for NazarAbad Azad University   
 Summer 1401/05/01
 Supervisor Mr.Minofam
*/
namespace RestaurantManagement
{
    public partial class frm_Food : DevExpress.XtraEditors.XtraForm
    {
        public frm_Food()
        {
            InitializeComponent();
            Load();
        }
        frm_FoodCore foodCore = new frm_FoodCore();
        private void Load()
        {
            //Fill into the cmb_FoodType from database
            Utility.FillToLookUpEdit("FoodStausText", "FoodStatusID", cmb_FoodType).Properties.DataSource = foodCore.FoodStatus();
            //Fill into the cmb_FoodType from database
            Utility.FillToLookUpEdit("FoodTypeText", "FoodTypeID", cmb_FoodDeatails).Properties.DataSource = foodCore.FoodTypeList();
            gcFoods.DataSource = foodCore.ActiveFoodsList();
        }
        private int FoodID = -1;
        private void btnUpsert_Click(object sender, EventArgs e)
        {
            if (FoodID == -1)
            {
                foodCore.AddNewFood(new RestaurantManagmentDataLayer.tbl_Food
                {
                    Active = true,
                    FoodStatusID = Convert.ToInt32(cmb_FoodType.EditValue),
                    FoodText = txtFoodName.Text,
                    Price = txtFoodPrice.Text,
                    FoodTypeID = Convert.ToInt32(cmb_FoodDeatails.EditValue)
                });
            }
            else
            {
                foodCore.UpdateNewFood(new RestaurantManagmentDataLayer.tbl_Food
                {
                    FoodID=FoodID,
                    Active = true,
                    FoodStatusID = Convert.ToInt32(cmb_FoodType.EditValue),
                    FoodText = txtFoodName.Text,
                    Price = txtFoodPrice.Text,
                    FoodTypeID = Convert.ToInt32(cmb_FoodDeatails.EditValue)
                });
            }
            btnUpsert.Text = "ثبت";
            btnReject.Visible = false;
            FoodID = -1;
            Load();
            //clear Component after update And Insert
            foreach (Control item in GroupInfo.Controls)
            {
                if (item.GetType().Name=="TextEdit")
                {
                    item.Text = null;            
                }
                if (item.GetType().Name == "LookUpEdit")
                {

                    LookUpEdit Look = item as LookUpEdit;
                    Look.Text = null;
                    Look.EditValue = null;
                }
            }


        }


        private void btnReject_Click(object sender, EventArgs e)
        {
            //clear Component after Click on Reject Button
            foreach (Control item in GroupInfo.Controls)
            {
                if (item.GetType().Name == "TextEdit")
                {
                    item.Text = null;
                }
                if (item.GetType().Name == "LookUpEdit")
                {
                    LookUpEdit Look = item as LookUpEdit;
                    Look.Text = null;
                    Look.EditValue = null;
                }
            }
            btnReject.Visible = false;
            FoodID = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //clear Component after Click on Reject Button
            FoodID = Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID));
            var Foods = foodCore.FindFood(Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID)));
            txtFoodName.Text = Foods.FoodText;
            txtFoodPrice.Text = Foods.Price;
            cmb_FoodDeatails.EditValue = Foods.FoodTypeID;
            cmb_FoodType.EditValue = Foods.FoodStatusID;
            btnReject.Visible = true;
            btnUpsert.Text = "ویرایش";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            foodCore.ActiveDeactivateFood(Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID)), false);
            Load();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            foodCore.ActiveDeactivateFood(Convert.ToInt32(gvFoods.GetRowCellValue(gvFoods.FocusedRowHandle, colFoodID)), true);
            gcFoods.DataSource = foodCore.DeactivateFoodsList();
        }

        private void btnActiveFoods_Click(object sender, EventArgs e)
        {
            gcFoods.DataSource = foodCore.ActiveFoodsList();
            btnRestore.Visible = false;
        }

        private void btnDeaActiveFoods_Click(object sender, EventArgs e)
        {
            btnRestore.Visible = true;
            gcFoods.DataSource = foodCore.DeactivateFoodsList();
        }
    }
}