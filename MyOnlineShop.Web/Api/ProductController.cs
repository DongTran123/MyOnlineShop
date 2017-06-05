using MyOnlineShop.Service;
using MyOnlineShop.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyOnlineShop.Web.Api
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {
        IProductService _IProductService;

        public ProductController(IErrorService IErrorService, IProductService IProductService) : base(IErrorService)
        {
            this._IProductService = IProductService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () => 
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

                }
                else
                {
                    var ListProduct = _IProductService.GetAll();
                    response = request.CreateResponse(HttpStatusCode.OK, ListProduct);
                }
                return response;
            });
        }
    }
}
