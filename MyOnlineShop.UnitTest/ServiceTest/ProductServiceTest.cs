using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Model.Models;
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
        IDbFactory _IDbFactory;
        IUnitOfWork _IUnitOfWork;
        IProductRepository _IProductRepository;
        IProductService IProductService;
        [TestInitialize]
        public void Initialize()
        {
            _IDbFactory = new DbFactoryImp();
            _IUnitOfWork = new UnitOfWork(_IDbFactory);
            _IProductRepository = new ProductRepository(_IDbFactory);
            IProductService = new ProductService(_IProductRepository, _IUnitOfWork);
        }
        public ProductServiceTest()
        {

        }
        [TestMethod]
        public void GetAllService()
        {
           var result = IProductService.GetAll().ToList();
            Assert.IsNotNull(result);
        }
    }
}
