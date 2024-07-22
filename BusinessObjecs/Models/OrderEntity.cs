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
        public string? PromotionID { get; set; }
        [ForeignKey(nameof(PromotionID))]
        public virtual PromotionEntity Promotion { get; set; }
        public required string UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual UserEntity User { get; set; }
        public virtual ICollection<OrderDetailEntity> OrderDetails { get; set; }
        public required string Status { get; set; }
        public decimal? PrimaryPrice { get; set; }
        public decimal? Total { get; set; }
    }
}
