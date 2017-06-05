namespace MyOnlineShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }

        public int ProductCategoryID { set; get; }

        public int TradeMarkID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Image { set; get; }

        public string Image1 { set; get; }

        public string Image2 { set; get; }

        public string Image3 { set; get; }

        public string MoreImage { set; get; }

        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }

        public int Quantity { set; get; }
        public int? Warranty { set; get; }

        public string Description { set; get; }
        public string Contentt { set; get; }
        public int ViewCount { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual ProductCategoryViewModel ProductCategory { set; get; }

        public virtual TradeMarkViewModel TradeMark { set; get; }
    }
}