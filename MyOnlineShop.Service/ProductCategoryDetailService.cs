using System;
using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using MyOnlineShop.Model.Models;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace MyOnlineShop.Service
{
    public interface IProductCategoryDetailService
    {
        void Add(ProductCategoryDetail Entity);
        void Update(ProductCategoryDetail Entity);
        void Delete(ProductCategoryDetail Entity);
        void DeleteMulti(Expression<Func<ProductCategoryDetail, bool>> Where);
        ProductCategoryDetail GetSingleByID(int Id);
        ProductCategoryDetail GetSingleByCondition(Expression<Func<ProductCategoryDetail, bool>> Where);
        IEnumerable<ProductCategoryDetail> GetAll();
        IEnumerable<ProductCategoryDetail> GetMany(Expression<Func<ProductCategoryDetail, bool>> Where);
        void Save();
    }
    public class ProductCategoryDetailService : IProductCategoryDetailService
    {
        IProductCategoryDetailRepository IProductCategoryDetailRepository;
        IUnitOfWork IUnitOfWork;
        public ProductCategoryDetailService(IProductCategoryDetailRepository IProductCategoryDetailRepository, IUnitOfWork IUnitOfWork)
        {
            this.IProductCategoryDetailRepository = IProductCategoryDetailRepository;
            this.IUnitOfWork = IUnitOfWork;
        }
        public void Add(ProductCategoryDetail Entity)
        {
            IProductCategoryDetailRepository.Add(Entity);
        }

        public void Delete(ProductCategoryDetail Entity)
        {
            IProductCategoryDetailRepository.Delete(Entity);
        }

        public void DeleteMulti(Expression<Func<ProductCategoryDetail, bool>> Where)
        {
            IProductCategoryDetailRepository.DeleteMulti(Where);
        }

        public IEnumerable<ProductCategoryDetail> GetAll()
        {
            return IProductCategoryDetailRepository.GetAll();
        }

        public IEnumerable<ProductCategoryDetail> GetMany(Expression<Func<ProductCategoryDetail, bool>> Where)
        {
            return IProductCategoryDetailRepository.GetMany(Where);
        }

        public ProductCategoryDetail GetSingleByCondition(Expression<Func<ProductCategoryDetail, bool>> Where)
        {
            return IProductCategoryDetailRepository.GetSingleByCondition(Where);
        }

        public ProductCategoryDetail GetSingleByID(int Id)
        {
            return IProductCategoryDetailRepository.GetSingleByID(Id);
        }

        public void Save()
        {
            IUnitOfWork.Commit();
        }

        public void Update(ProductCategoryDetail Entity)
        {
            IProductCategoryDetailRepository.Update(Entity);
        }
    }
}
