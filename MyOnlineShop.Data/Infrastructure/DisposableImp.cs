using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Data.Infrastructure
{
    public class DisposableImp : IDisposable
    {
        private bool isDisposed;

        ~DisposableImp()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
