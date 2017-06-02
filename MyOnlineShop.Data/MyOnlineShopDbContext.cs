using System;
using MyOnlineShop.Model.Models;
using System.Data.Entity;

namespace MyOnlineShop.Data
{
   public  class MyOnlineShopDbContext:DbContext
    {
        public MyOnlineShopDbContext() : base("MyOnlineShop")
        {
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategory { set; get; }
        public DbSet<ProductCategoryDetail> ProductCategoryDetails { set; get; }
        public DbSet<Slide> Slides { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }

    }
}
