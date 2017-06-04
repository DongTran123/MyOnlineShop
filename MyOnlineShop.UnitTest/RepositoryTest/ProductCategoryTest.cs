using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;


namespace MyOnlineShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class ProductCategoryTest
    {
        IDbFactory IDbFactory;
        IProductCategoryRepository IProductCategoryRepository;
        IUnitOfWork IUnitOfWork;
        [TestInitialize]
        public void Initialze()
        {
            IDbFactory = new DbFactoryImp();
            IUnitOfWork = new UnitOfWork(IDbFactory);
            IProductCategoryRepository = new ProductCategoryRepository(IDbFactory);
           
        }
        [TestMethod]
        public void GetAll()
        {
            var result = IProductCategoryRepository.GetAll();
            Assert.IsNotNull(result);
        }
    }
}
