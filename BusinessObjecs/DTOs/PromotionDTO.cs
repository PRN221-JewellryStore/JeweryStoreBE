using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class PromotionDTO
    {
        public string? Description { get; set; }
        public decimal ConditionsOfUse { get; set; }
        public float ReducedPercent { get; set; }
        public decimal MaximumReduce { get; set; }
        public int ExchangePoint { get; set; }
        public DateTime ExpiresTime { get; set; }
        public string? UserID { get; set; }
    }
}
