using AutoMapper;
using BusinessObjecs.Models.Configured;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class CounterDTO
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CounterEntity, CounterDTO > ()
              .ReverseMap();
        }
    /*    public CounterDTO()
        {
            Category = new CategoryDTO(); // Initialize CategoryDTO in the constructor
        }*/
        //  public int ID { get; set; }
        public string Name { get; set; }
        public  int CategoryID { get; set; }
        //public CategoryDTO Category { get; set; }
        public static CounterDTO Create(string Name)
        {
            return new CounterDTO
            {
                //CategoryID = CategoryId,

                Name = Name,
                         /*  Category = category,*/

            };
        }


    }
    public class CounterDTOResponse
    {
        // Mapping is handled by the same MappingProfile class as CounterDTO
        public string Name { get; set; }
        public CategoryDTO Category { get; set; }

        public static CounterDTOResponse Create(string Name, CategoryDTO category)
        {
            return new CounterDTOResponse
            {
                Name = Name,
                Category = category,
            };
        }


    }
}
