using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
    public class ProductServiceTestMoq
    {
        private Mock<IProductRepository> mocProductRepository;
        private Mock<IUnitOfWork> mocUnitOfWork;
        private IProductService IProductService;
        private List<Product> ListProduct;
        [TestInitialize]
        public void Initialze()
        {
            mocProductRepository = new Mock<IProductRepository>();
            mocUnitOfWork = new Mock<IUnitOfWork>();
            IProductService = new ProductService(mocProductRepository.Object, mocUnitOfWork.Object);
            ListProduct = new List<Product>() {
                new Product() {ProductCategoryID=1,TradeMarkID=1,Name="123",Quantity=1,ViewCount=1,Status=true,Price=1 },
                new Product() {ProductCategoryID=1,TradeMarkID=1,Name="123",Quantity=1,ViewCount=1,Status=true,Price=1 },
            };

        }
        [TestMethod]
        public void TestGetAll()
        {
            mocProductRepository.Setup(m => m.GetAll());
            var result = IProductService.GetAll();
            Assert.IsNotNull(result);
        }
    }
}
