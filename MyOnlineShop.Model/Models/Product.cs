using MyOnlineShop.Model.Inheritance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOnlineShop.Model.Models
{
    [Table("Products")]
    public class Product:ASeoCreateStatusImp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public int ProductCategoryDetailID { set; get; }
        [ForeignKey("ProductCategoryDetailID")]
        public virtual ProductCategoryDetails ProductCategoryDetail { set; get; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Image { set; get; }
        [MaxLength(500)]
        public string Image1 { set; get; }
        [MaxLength(500)]
        public string Image2 { set; get; }
        [MaxLength(500)]
        public string Image3 { set; get; }
        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }
        [Required]
        public decimal Price { set; get; }
        public decimal PromotionPrice { set; get; }
        [Required]
        public int Quantity { set; get; }
        public int? Warranty { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Contentt { set; get; }
        public int ViewCount { set; get; }
        public bool? HomeFlag { set; get; }

    }
}
