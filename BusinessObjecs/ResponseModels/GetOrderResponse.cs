
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
    public class GetOrderResponse
    {
        public string ID { get; set; }
        public string? PromotionID { get; set; }
        public Promotion Promotion { get; set; }
        public required string UserID { get; set; }
        public UserDTO User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; } = [];
        public required string Status { get; set; }
        public decimal? PrimaryPrice { get; set; }
        public decimal? Total { get; set; }
    }
}
