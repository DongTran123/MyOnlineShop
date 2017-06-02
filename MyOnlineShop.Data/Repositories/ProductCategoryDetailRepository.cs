using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
namespace MyOnlineShop.Data.Repositories
{
    public interface IProductCategoryDetailRepository:IRepository<ProductCategoryDetail>
    {

    }
    public class ProductCategoryDetailRepository : RepositoryBase<ProductCategoryDetail>, IProductCategoryDetailRepository
    {
        public ProductCategoryDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
