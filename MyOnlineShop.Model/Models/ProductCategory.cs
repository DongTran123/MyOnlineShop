using MyOnlineShop.Model.Inheritance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory:ASeoCreateStatusImp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Alias { set; get; }
        public int?DisplayOrder { set; get; }
        [MaxLength(500)]
        public string Image { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public bool? HomeFlag { set; get; }

        
        public virtual IEnumerable<ProductCategoryDetails> ProductCategoryDetails { set; get; }

    }
}
