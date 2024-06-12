using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class OrderDetailDTO
    {
        public string OrderID { get; set; } = null!;
        public string ProductID { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal ProductCost { get; set; }
    }
}
