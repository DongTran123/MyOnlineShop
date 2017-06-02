﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
namespace MyOnlineShop.Data.Repositories
{
    public class ProductCategoryDetailRepository : RepositoryBase<ProductCategoryDetail>
    {
        public ProductCategoryDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
