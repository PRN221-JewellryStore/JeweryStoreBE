﻿using BusinessObjecs.ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.ResponseModels
{
    public class GetOrderDetailResponse
    {
        public string ID { get; set; }
        public string OrderID { get; set; }
        public Order Order { get; set; }
        public string ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal ProductCost { get; set; }
    }
}
