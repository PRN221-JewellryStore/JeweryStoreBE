using BusinessObjecs.DTOs;
using BusinessObjecs.ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels
{
    public class GetPromotionResponse
    {
        public string ID { get; set; }
        public string? Description { get; set; }
        public required decimal ConditionsOfUse { get; set; }
        public required float ReducedPercent { get; set; }
        public required decimal MaximumReduce { get; set; }
        public required DateTime ExpiresTime { get; set; }
        public string? UserID { get; set; }
        public UserDTO User { get; set; }
        public List<Order> Orders { get; set; } = [];
        public required string Status { get; set; }
    }
}
