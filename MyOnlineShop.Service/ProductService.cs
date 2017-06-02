using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyOnlineShop.Service
{
    public interface IProductService
    {
        void Add(Product Product);
        void Update(Product Product);
        void Delete(Product Product);
        Product GetSingleByID(int Id);
        Product GetSingleByCondition(Expression<Func<Product, bool>> Where);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetMany(Expression<Func<Product, bool>> Where);
        void Save();
    }
    public class ProductService : IProductService
    {
        IProductRepository IProductRepository;
        IUnitOfWork IUnitOfWork;
        public  ProductService(IProductRepository IProductRepository, IUnitOfWork IUnitOfWork)
        {
            this.IProductRepository = IProductRepository;
            this.IUnitOfWork = IUnitOfWork;
        }
        public void Add(Product Product)
        {
            IProductRepository.Add(Product);
        }

        public void Delete(Product  Product )
        {
            IProductRepository.Delete(Product );
        }
        public void Update(Product  Product )
        {
            IProductRepository.Update(Product );
        }
        public IEnumerable<Product > GetAll()
        {
            return IProductRepository.GetAll();
        }

        public IEnumerable<Product > GetMany(Expression<Func<Product , bool>> Where)
        {
            return IProductRepository.GetMany(Where);
        }

        public Product  GetSingleByCondition(Expression<Func<Product , bool>> Where)
        {
            return IProductRepository.GetSingleByCondition(Where);
        }

        public Product  GetSingleByID(int Id)
        {
            return IProductRepository.GetSingleByID(Id);
        }
        public void Save()
        {

            IUnitOfWork.Commit();
        }
    }
}
