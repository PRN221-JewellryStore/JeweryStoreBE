using AutoMapper;
using BusinessObjecs.Mapping;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessObjecs.DTOs
{
    public class CategoryDTO : IMapFrom<CategoryEntity>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CategoryEntity, CategoryDTO>()
              .ReverseMap();
        }
        public int ID { get; set; }

        public string Name { get; set; }
        public static CategoryDTO Create(string Name, int ID)
        {
            return new CategoryDTO
            {
                ID = ID,    
                Name = Name,
            };
        }
    }
}
