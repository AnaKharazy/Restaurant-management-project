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
    
    public partial class tbl_OrderKind
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OrderKind()
        {
            this.tbl_Factor = new HashSet<tbl_Factor>();
        }
    
        public int OrderKindID { get; set; }
        public string OrderKindText { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Factor> tbl_Factor { get; set; }
    }
}