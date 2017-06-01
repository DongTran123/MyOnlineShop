
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOnlineShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set;get;}
        [Required]
        [StringLength(250)]
        public string Name { set; get; }
        [Required]
        [StringLength(500)]
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        [Required]
        public int GroupID { set; get; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
        [StringLength(50)]
        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }
    }
}
