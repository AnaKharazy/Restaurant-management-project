//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManagmentDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Food()
        {
            this.tbl_Order = new HashSet<tbl_Order>();
        }
    
        public int FoodID { get; set; }
        public Nullable<int> FoodStatusID { get; set; }
        public Nullable<int> FoodTypeID { get; set; }
        public string FoodText { get; set; }
        public string Price { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual tbl_FoodStatus tbl_FoodStatus { get; set; }
        public virtual tbl_FoodType tbl_FoodType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Order> tbl_Order { get; set; }
    }
}