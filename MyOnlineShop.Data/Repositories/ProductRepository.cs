using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
namespace MyOnlineShop.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
