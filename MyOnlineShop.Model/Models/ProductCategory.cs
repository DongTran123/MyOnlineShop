using MyOnlineShop.Model.Inheritance;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

       
       public virtual IEnumerable<Product> Products { set; get; }

    }
}
