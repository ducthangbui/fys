﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FYSVersion1Entities : DbContext
    {
        public FYSVersion1Entities()
            : base("name=FYSVersion1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Buy> Buys { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Design> Designs { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Follow> Follows { get; set; }
        public virtual DbSet<GroupPost> GroupPosts { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<Save> Saves { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
