using MyOnlineShop.Model.Models;
using MyOnlineShop.Service;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyOnlineShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        public ApiControllerBase(IErrorService IErrorService)
        {
            _IErrorService = IErrorService;
        }
        private IErrorService _IErrorService { set; get; }
        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;
            try
            {
                response = function.Invoke();
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return null;
        }

        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.Message = ex.Message;
                error.StrackTrace = ex.StackTrace;
                error.CreatedDate = DateTime.Now;
                _IErrorService.Save();
            }
            catch
            {
            }
        }
    }
}