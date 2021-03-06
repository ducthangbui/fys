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
    
    public partial class Post
    {
        public int PostId { get; set; }
        public Nullable<int> UserPostId { get; set; }
        public Nullable<int> GroupPostId { get; set; }
        public Nullable<int> Type { get; set; }
        public string Text { get; set; }
        public Nullable<double> Price { get; set; }
        public string OrderDelivery { get; set; }
        public Nullable<int> StatusProduct { get; set; }
        public Nullable<double> EstimatedBudget { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> PictureId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    
        public virtual Picture Picture { get; set; }
        public virtual User User { get; set; }
    }
}
