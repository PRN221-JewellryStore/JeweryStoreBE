using AutoMapper;
using BusinessObjecs.Mapping;
using BusinessObjecs.ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class ProductDTO : IMapFrom<Product>
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public float Weight { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int CategoryID { get; set; }
        public CategoryDTO Category { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDTO>();
        }
    }
}
