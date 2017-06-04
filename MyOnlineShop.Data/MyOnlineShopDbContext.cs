﻿using System;
using MyOnlineShop.Model.Models;
using System.Data.Entity;

namespace MyOnlineShop.Data
{
    public class MyOnlineShopDbContext : DbContext
    {
        public MyOnlineShopDbContext() : base("MyOnlineShop")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategorys { set; get; }
        public DbSet<TradeMark> TradeMarks { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<Error> Errors { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
