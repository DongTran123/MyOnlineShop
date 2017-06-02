using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
namespace MyOnlineShop.Data.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
