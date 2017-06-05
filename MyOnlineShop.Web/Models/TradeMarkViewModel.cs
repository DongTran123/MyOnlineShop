using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOnlineShop.Web.Models
{
    public class TradeMarkViewModel
    {
   
        public int ID { set; get; }
    
        public string Name { set; get; }

        public string Alias { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public string Description { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}