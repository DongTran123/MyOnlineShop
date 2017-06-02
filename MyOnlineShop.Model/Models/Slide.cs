
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOnlineShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int Id { set; get; }
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        [MaxLength(500)]
        public string URL { set; get; }

        public int DisplayOrder { set; get; }

        public bool Status { set; get; }

    }
}
