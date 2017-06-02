using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Data.Infrastructure
{
    public class DbFactoryImp : DisposableImp, IDbFactory
    {
        MyOnlineShopDbContext dbContext;

        public MyOnlineShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MyOnlineShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
 