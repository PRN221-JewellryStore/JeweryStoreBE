﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.DTOs
{
    public class RegisterDTO
    {
        public RegisterDTO(string username, string password, string fullName, string email, string phoneNumber, string address, int roleID)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            RoleID = roleID;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int RoleID { get; set; }
    }
}
