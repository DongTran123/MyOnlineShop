
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
namespace MyOnlineShop.Data.Repositories
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
