using BusinessObjecs.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels.Models
{
    public class Promotion
    {
        public string ID { get; set; }
        public string Description { get; set; } = null!;
        public decimal ConditionsOfUse { get; set; }
        public float ReducedPercent { get; set; }
        public decimal MaximumReduce { get; set; }
        public DateTime ExpiresTime { get; set; }
    }
}
