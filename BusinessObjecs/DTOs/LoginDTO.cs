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
        public LoginDTO()
        {
            
        }
        public LoginDTO(LoginEntity loginEntity)
        {
            user.Email = loginEntity.Email;
            user.Password = loginEntity.Password;
        }
        public required LoginEntity user { get; set; }
    }
}
