//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantPOSFINAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItemTbl
    {
        public MenuItemTbl()
        {
            this.CheckItemTbls = new HashSet<CheckItemTbl>();
        }
    
        public int ItemID { get; set; }
        public int ItemCategory { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<CheckItemTbl> CheckItemTbls { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}
