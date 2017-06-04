using MyOnlineShop.Data.Infrastructure;
using MyOnlineShop.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Service
{
    public interface IErrorService
    {
        
        void Save();
    }
    public class ErrorService : IErrorService
    {
        IErrorRepository _IErrorRepository;
        IUnitOfWork _IUnitOfWork;
        public ErrorService(IErrorRepository IErrorRepository, IUnitOfWork IUnitOfWork)
        {
            _IErrorRepository = IErrorRepository;
            _IUnitOfWork = IUnitOfWork;
        }
        public void Save()
        {
            _IUnitOfWork.Commit();
        }
    }
}
