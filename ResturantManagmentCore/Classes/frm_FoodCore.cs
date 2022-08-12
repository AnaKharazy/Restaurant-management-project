using RestaurantManagmentDataLayer;
using ResturantManagmentCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Classes
{
    public class frm_FoodCore
    {
        RestaurantManagementEntities Context = new RestaurantManagementEntities();
        //this method insert new food
        public bool AddNewFood(tbl_Food food)
        {
            try
            {
                Context.tbl_Food.Add(food);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //this method Update foods
        public bool UpdateNewFood(tbl_Food Food)
        {
            try
            {
                var food = Context.tbl_Food.Find(Food.FoodID);
                food.FoodStatusID = Food.FoodStatusID;
                food.FoodText = Food.FoodText;
                food.FoodTypeID = Food.FoodTypeID;
                food.Price = Food.Price;
                Context.Entry(food).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //this method set Active or Deactive to the FoodID
        public bool ActiveDeactivateFood(int FoodID, bool Active)
        {
            try
            {
                var Food = Context.tbl_Food.Find(FoodID);
                Food.Active = Active;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //this method return Active FoodsModel as list
        public List<FoodsModel> ActiveFoodsList()
        {
            return Context.tbl_Food.Where(a=>a.Active==true).Select(a => new FoodsModel
            {
                FoodID = a.FoodID,
                FoodStausText = a.tbl_FoodStatus.FoodStausText,
                FoodText = a.FoodText,
                FoodTypeText = a.tbl_FoodType.FoodTypeText
                ,Price=a.Price
            }).ToList();
        }
        //this method return Deactivate FoodsModel as list
        public List<FoodsModel> DeactivateFoodsList()
        {
            return Context.tbl_Food.Where(a => a.Active == false).Select(a => new FoodsModel
            {
                FoodID = a.FoodID,
                FoodStausText = a.tbl_FoodStatus.FoodStausText,
                FoodText = a.FoodText,
                FoodTypeText = a.tbl_FoodType.FoodTypeText
                ,
                Price = a.Price
            }).ToList();
        }
        //this method return  FoodTypeList as list
        public List<tbl_FoodType> FoodTypeList()
        {
            return Context.tbl_FoodType.ToList();
        }
        //this method return  FoodStatus as list
        public List<tbl_FoodStatus> FoodStatus()
        {
            return Context.tbl_FoodStatus.ToList();
        }
        //this method return Food information base on FindID
        public tbl_Food FindFood(int FoodID)
        {
            return Context.tbl_Food.Find(FoodID);
        }
    }
}
