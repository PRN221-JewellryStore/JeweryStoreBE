using AutoMapper;
using BCrypt.Net;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;

namespace Repositories.RepositoryImpl
{
    public class UserRepository : RepositoryBase<UserEntity, UserEntity, JeweryStoreDBContext>, IUserRepository
    {
        private readonly JeweryStoreDBContext _dbContext;

        public UserRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext =dbContext;
        }

        public async Task<UserEntity> Get(string email)
        {
            return await _dbContext.userEntities.FirstOrDefaultAsync(x => x.Email == email);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
