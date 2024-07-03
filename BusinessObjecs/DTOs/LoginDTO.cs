using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class LoginDTO
    {
        public LoginDTO(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
