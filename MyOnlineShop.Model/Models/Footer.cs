
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOnlineShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [StringLength(50)]
        public string ID { set; get; }
        [Required]
        public string Contentt { set; get; } 
    }
}
