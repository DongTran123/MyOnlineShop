using MyOnlineShop.Model.Inheritance;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyOnlineShop.Model.Models
{
    [Table("ProductCategoryDetails")]
    public  class ProductCategoryDetails:ASeoCreateStatusImp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public int ProductCategoryID { set; get; }

        [ForeignKey("ProductCategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Alias { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
