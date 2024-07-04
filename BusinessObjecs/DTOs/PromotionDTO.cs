using BusinessObjecs.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class PromotionDTO
    {
        [Required]
        public string Description { get; set; } = null!;
        public decimal ConditionsOfUse { get; set; }
        public float ReducedPercent { get; set; }
        public decimal MaximumReduce { get; set; }
        public int ExchangePoint { get; set; }
        public DateTime ExpiresTime { get; set; }
        [Required]
        public string UserID { get; set; } = null!;
    }
}
