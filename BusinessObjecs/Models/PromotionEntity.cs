﻿using BusinessObjecs.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models
{
    [Table("Promotion")]
    public class PromotionEntity : BaseEntity
    {
        public string? Description { get; set; }
        public required decimal ConditionsOfUse { get; set; }
        public required float ReducedPercent { get; set; }
        public required decimal MaximumReduce { get; set; }
        public required DateTime ExpiresTime { get; set; }
        public string? UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual UserEntity User { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
        public required string Status { get; set; }

    }
}
