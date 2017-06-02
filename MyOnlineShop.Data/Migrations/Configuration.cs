namespace MyOnlineShop.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyOnlineShop.Data.MyOnlineShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyOnlineShop.Data.MyOnlineShopDbContext context)
        {
            
        }
    }
}
