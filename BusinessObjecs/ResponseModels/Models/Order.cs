using BusinessObjecs.Models.Configured;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels.Models
{
    public class Order
    {
        public string ID { get; set; }
        public string Note { get; set; }
        public string? PromotionID { get; set; }
        public int? CounterID { get; set; }
        public string UserID { get; set; }
        public decimal? PrimaryPrice { get; set; }
        public decimal? Total { get; set; }

    }
}
