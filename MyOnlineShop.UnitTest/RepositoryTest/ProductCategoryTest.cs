using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;


namespace MyOnlineShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class ProductCategoryTest
    {
        IDbFactory _IDbFactory;
        IProductCategoryRepository _IProductCategoryRepository;
        IUnitOfWork _IUnitOfWork;
        [TestInitialize]
        public void Initialze(/*IDbFactory IDbFactory, IProductCategoryRepository IProductCategoryRepository, IUnitOfWork IUnitOfWork*/)
        {
            //_IDbFactory = IDbFactory;
            //_IProductCategoryRepository = IProductCategoryRepository;
            //_IUnitOfWork = IUnitOfWork;
            _IDbFactory = new DbFactoryImp();
            _IUnitOfWork = new UnitOfWork(_IDbFactory);
            _IProductCategoryRepository = new ProductCategoryRepository(_IDbFactory);


        }
        [TestMethod]
        public void GetAll()
        {
            var result = _IProductCategoryRepository.GetAll();

            Assert.IsNotNull(result);

        }
    }
}
