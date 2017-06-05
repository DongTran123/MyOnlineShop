using AutoMapper;
using MyOnlineShop.Service;
using MyOnlineShop.Web.Infrastructure.Core;
using MyOnlineShop.Web.Models;
using System.Collections.Generic;
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
                var ListProductVM = Mapper.Map<List<ProductViewModel>>(ListProduct);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, ListProductVM);
                return response;
            });
        }
    }
}