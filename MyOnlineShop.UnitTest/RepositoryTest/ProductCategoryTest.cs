using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IProductCategoryRepository = new ProductCategoryRepository(IDbFactory);
            IUnitOfWork = new UnitOfWork(IDbFactory);
        }
        [TestMethod]
        public void AddProductCategory()
        {
          

            var result = IProductCategoryRepository.GetAll();
            Assert.IsNotNull(result);
        }
    }
}
