using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MyOnlineShop.Data.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
        ICollection<Product> GetAllColection();
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        ICollection<Product> IProductRepository.GetAllColection()
        {
            return this.DbContext.Products.ToList();
        }
    }
}
