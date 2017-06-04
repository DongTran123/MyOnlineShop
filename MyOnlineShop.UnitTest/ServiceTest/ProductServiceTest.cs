using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.UnitTest.ServiceTest
{
    [TestClass]
    public class ProductServiceTest
    {
        IDbFactory IDbFactory;
        IUnitOfWork IUnitOfWork;
        IProductRepository IProductRepository;
        IProductService IProductService;
        [TestInitialize]
        public void Initialize()
        {
           
            IDbFactory = new DbFactoryImp();
            this.IUnitOfWork = new UnitOfWork(IDbFactory);
            this.IProductRepository = new ProductRepository(IDbFactory);
            IProductService = new ProductService(IProductRepository, IUnitOfWork);
        }
        [TestMethod]
        public void GetAllService()
        {
            var result = IProductService.GetAll();
            Assert.IsNotNull(result);
        }
    }
}
