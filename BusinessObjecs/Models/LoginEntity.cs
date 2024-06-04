using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models
{
    [NotMapped]
    public class LoginEntity
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
