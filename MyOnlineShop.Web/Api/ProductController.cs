using MyOnlineShop.Service;
using MyOnlineShop.Web.Infrastructure.Core;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyOnlineShop.Web.Api
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {
        private IProductService _IProductService;

        public ProductController(IErrorService IErrorService, IProductService IProductService) : base(IErrorService)
        {
            this._IProductService = IProductService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var ListProduct = _IProductService.GetAll();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, ListProduct);
                return response;
            });
        }
    }
}