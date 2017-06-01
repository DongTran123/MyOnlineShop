using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOnlineShop.Model.Inheritance
{
    public abstract class ASeoCreateStatusImp : ISeoCreateStatus
    {
            public DateTime? CreateDate { set; get; }
            [StringLength(50)]
            public string CreateBy { set; get; }
           public DateTime? UpdateDate { set; get; }
           public string UpdateBy { set; get; }
           [StringLength(250)]
           public string MetaKeyword { set; get; }
           [StringLength(250)]
           public string MetaDescription { set; get; }
           [Required]
           public bool Status { set; get; }
    }
}
