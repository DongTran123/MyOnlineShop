using AutoMapper;
using MyOnlineShop.Model.Models;
using MyOnlineShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOnlineShop.Web.AutoMappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<TradeMark, TradeMarkViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
            });
        }
    }
}