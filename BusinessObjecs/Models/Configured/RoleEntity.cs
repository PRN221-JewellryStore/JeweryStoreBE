using BusinessObjecs.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models.Configured
{
    [Table("Role")]
    public class RoleEntity : ConfigTable
    {
        public virtual ICollection<UserEntity> Users { get; set; }
    }
}
