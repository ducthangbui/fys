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
    
    public partial class Bid
    {
        public int BidId { get; set; }
        public Nullable<int> UserBidId { get; set; }
        public Nullable<int> PostBidId { get; set; }
        public string Text { get; set; }
        public Nullable<double> PriceBid { get; set; }
        public Nullable<System.DateTime> TimeDone { get; set; }
        public Nullable<double> Deposit { get; set; }
        public string PaymentMethods { get; set; }
        public string OrderDelivery { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual User User { get; set; }
    }
}