using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace MyOnlineShop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory ProductCategory);
        void Update(ProductCategory ProductCategory);
        void Delete(ProductCategory ProductCategory);
        ProductCategory GetSingleByID(int Id);
        ProductCategory  GetSingleByCondition(Expression<Func<ProductCategory, bool>> Where);
        IEnumerable<ProductCategory> GetAll();
        IEnumerable<ProductCategory> GetMany(Expression<Func<ProductCategory, bool>> Where);
        void Save();
    }
    public class ProductCategoryService : IProductCategoryService
    {
        IProductCategoryRepository IProductCategoryRepository;
        IUnitOfWork IUnitOfWork;
        public  ProductCategoryService(IProductCategoryRepository IProductCategoryRepository, IUnitOfWork IUnitOfWork)
        {
            this.IProductCategoryRepository = IProductCategoryRepository;
            this.IUnitOfWork = IUnitOfWork;
        }
        public void Add(ProductCategory ProductCategory)
        {
            IProductCategoryRepository.Add(ProductCategory);
        }

        public void Delete(ProductCategory ProductCategory)
        {
            IProductCategoryRepository.Delete(ProductCategory);
        }
        public void Update(ProductCategory ProductCategory)
        {
            IProductCategoryRepository.Update(ProductCategory);
        }
        public IEnumerable<ProductCategory> GetAll()
        {
            return IProductCategoryRepository.GetAll();
        }
        
        public IEnumerable<ProductCategory> GetMany(Expression<Func<ProductCategory, bool>> Where)
        {
            return IProductCategoryRepository.GetMany(Where);
        }

        public ProductCategory GetSingleByCondition(Expression<Func<ProductCategory, bool>> Where)
        {
            return IProductCategoryRepository.GetSingleByCondition(Where);
        }

        public ProductCategory GetSingleByID(int Id)
        {
            return IProductCategoryRepository.GetSingleByID(Id);
        }
        public void Save()
        {
            IUnitOfWork.Commit();
        }
    }
}
