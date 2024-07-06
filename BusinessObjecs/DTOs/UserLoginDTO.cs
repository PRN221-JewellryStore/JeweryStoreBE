using AutoMapper;
using BusinessObjecs.Mapping;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessObjecs.DTOs
{
    public class UserLoginDTO : IMapFrom<UserEntity>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserEntity, UserLoginDTO>();
        }
        public string Username { get; set; }
        public string Email {  get; set; }
        public string ID { get; set; }
        public string Role { get; set; }
        public string Token {  get; set; }
        public static UserLoginDTO Create(string id, string username, string email, string role)
        {
            return new UserLoginDTO
            {
                Username = username,
                ID = id,
                Role = role,
                Email = email
            };
        }
    }
}
