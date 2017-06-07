using AutoMapper;
using MyOnlineShop.Model.Models;
using MyOnlineShop.Service;
using MyOnlineShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyOnlineShop.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductService  ProductService;
        public ProductController(IProductService IProductService)
        {
            ProductService = IProductService;
        }
        public ActionResult Index()
        {
            var ListProduct = ProductService.GetAll();
        
            var ListProductVM = Mapper.Map<List<ProductViewModel>>(ListProduct);
            return View(ListProductVM);
        }
    }
}