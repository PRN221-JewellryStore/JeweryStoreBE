using BusinessObjecs.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models.Configured
{
    [Table("Counter")]
    public class CounterEntity : ConfigTable
    {
        public required int CategoryID { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public virtual CategoryEntity Category { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
    }
}
