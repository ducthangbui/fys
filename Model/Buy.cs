//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy
    {
        public int BuyId { get; set; }
        public Nullable<int> UserBuyId { get; set; }
        public Nullable<int> PostBoughtId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual User User { get; set; }
    }
}
