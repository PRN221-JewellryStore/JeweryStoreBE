using AutoMapper;
using BCrypt.Net;
using BusinessObjecs.Models;
using Repositories.IRepository;

namespace Repositories.RepositoryImpl
{
    public class UserRepository : RepositoryBase<UserEntity, UserEntity, JeweryStoreDBContext>, IUserRepository
    {
        private readonly JeweryStoreDBContext _Context;

        public UserRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext,mapper)
        {
            _Context = dbContext;
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
