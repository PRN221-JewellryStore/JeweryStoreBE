
using BusinessObjecs.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels
{
    public class GetOrderResponse
    {
        public string ID { get; set; }
        public required string Note { get; set; }
        public string? PromotionID { get; set; }
        public PromotionDTO Promotion { get; set; }
        public int? CounterID { get; set; }
        public CounterDTO Counter { get; set; }
        public required string UserID { get; set; }
        public UserDTO User { get; set; }
        public virtual List<OrderDetailDTO> OrderDetails { get; set; } = [];
        public required string Status { get; set; }
        public decimal? Total { get; set; }
    }
}
