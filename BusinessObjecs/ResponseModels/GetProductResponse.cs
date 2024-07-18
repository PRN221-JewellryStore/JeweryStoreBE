using BusinessObjecs.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels
{
    public class GetProductResponse
    {
        public string ID { get; set; }
        public required decimal Cost { get; set; }
        public required float Weight { get; set; }
        public required int Quantity { get; set; }
        public string? Description { get; set; }
        public required int CategoryID { get; set; }
        public CategoryDTO Category { get; set; }
        public List<OrderDetailDTO> OrderDetails { get; set; } = [];
    }
}
