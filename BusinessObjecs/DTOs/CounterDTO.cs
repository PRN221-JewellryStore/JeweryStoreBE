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
        public string Name { get; set; }
        public  int CategoryID { get; set; }

        public static CounterDTO Create(string Name, int CategoryId)
        {
            return new CounterDTO
            {
                CategoryID = CategoryId,

                Name = Name,
            };
        }
    }
}
