using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IUserRepository : IEFRepository<UserEntity, UserEntity>
    {
        bool VerifyPassword(string password, string passwordHash);
        string HashPassword(string password);

        Task<UserEntity> Get(string email);
    }
}
