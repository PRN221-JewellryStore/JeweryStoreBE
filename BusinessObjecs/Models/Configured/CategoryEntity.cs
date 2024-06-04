using BusinessObjecs.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models.Configured
{
    [Table("Category")]
    public class CategoryEntity : ConfigTable
    {
        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
