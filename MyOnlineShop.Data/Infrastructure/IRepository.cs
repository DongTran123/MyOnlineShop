using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Data.Infrastructure
{
    
    public interface IRepository<T> where T:class
    {
        
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        void DeleteMulti(Expression<Func<T, bool>> Where);
        T GetSingleByID(int ID);
        T GetSingleByCondition(Expression<Func<T,bool>> Where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> Where);


        
    }
}
