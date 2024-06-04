using BusinessObjecs.Models.Base;
using BusinessObjecs.Models.Configured;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models
{
    [Table("Order")]
    public class OrderEntity : BaseEntity
    {
        public required string Note { get; set; }
        public string? PromotionID { get; set; }
        [ForeignKey(nameof(PromotionID))]
        public virtual PromotionEntity Promotion { get; set; }
        public int? CounterID { get; set; }
        [ForeignKey(nameof(CounterID))]
        public virtual CounterEntity Counter { get; set; }
        public required string UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual UserEntity User { get; set; }
        public virtual ICollection<OrderDetailEntity> OrderDetails { get; set; }
    }
}
