using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public float Weight { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int CategoryID { get; set; }
    }
}
