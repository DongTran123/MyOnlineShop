
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Model.Models;
namespace MyOnlineShop.Data.Repositories
{
    public interface IProductCategoryRepository:IRepository<ProductCategory>
    {

    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>,IProductCategoryRepository
    {
        
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
