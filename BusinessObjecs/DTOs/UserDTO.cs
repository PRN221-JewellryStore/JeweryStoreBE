using AutoMapper;
using BusinessObjecs.Mapping;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class UserDTO : IMapFrom<UserEntity>
    {
        public string ID {  get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int RoleID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserEntity, UserDTO>();
        }
    }
}
