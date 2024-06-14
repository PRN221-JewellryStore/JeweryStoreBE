using BusinessObjecs.DTOs;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        public UserServices(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }
        public async Task<UserLoginDTO> Login(LoginDTO query, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindAsync(x => x.Email == query.user.Email && x.DeletedAt == null, cancellationToken);
            if (user == null)
            {
                throw new NotFoundException($"Không tìm thấy tài khoản nào với email - {query.user.Email}");
            }
            if (user != null)
            {
                var role = await _roleRepository.FindAsync(x => x.ID == user.RoleID && x.DeletedAt == null, cancellationToken);
                if (role == null)
                {
                    throw new NotFoundException($"Không tìm thấy tài khoản với role - {query.user.Email}");
                }

                var checkPassword = _userRepository.VerifyPassword(query.user.Password, user.PasswordHash);
                if (checkPassword)
                {
                    return UserLoginDTO.Create(user.Email, user.ID, role.Name);
                }
            }
            throw new Exception("Tài khoản hoặc mật khẩu không đúng.");
        }
    }
}
