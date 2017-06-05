using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Data.Infrastructure
{
    public abstract class RepositoryBase<T>:IRepository<T> where T:class
    {
        private MyOnlineShopDbContext dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;

            private set;
        }

        protected MyOnlineShopDbContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
           
        }
        public virtual void DeleteMulti(Expression<Func<T, bool>> Where)
        {
            IEnumerable<T> objects = dbSet.Where(Where);
            foreach (var obj in objects)
                dbSet.Remove(obj);
        }
        public virtual T GetSingleByID(int Id)
        {
            return dbSet.Find(Id);
        }
        public virtual T GetSingleByCondition(Expression<Func<T,bool>> Where)
        {
            return dbSet.SingleOrDefault(Where);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbSet;
        }
        //public IEnumerable<T> GetAllPaging(int? Page,int ProductPerPage)
        //{
        //    return dbSet.

        //}
        public virtual IEnumerable<T>GetMany(Expression<Func<T,bool>> Where)
        {
            return dbSet.Where(Where);
        }

        public virtual T AddReturn(T Entity)
        {
            return dbSet.Add(Entity);
        }
    }
}
