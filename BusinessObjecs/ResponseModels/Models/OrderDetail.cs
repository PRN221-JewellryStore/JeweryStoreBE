using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels.Models
{
    public class OrderDetail
    {
        public string ID { get; set; }
        public string OrderID { get; set; } = null!;
        public string ProductID { get; set; } = null!;
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public decimal ProductCost { get; set; }

    }
}
