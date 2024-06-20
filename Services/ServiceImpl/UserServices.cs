using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
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

        public async Task<string> Register(RegisterDTO request, CancellationToken cancellationToken)
        {
            var isExist = await _userRepository.AnyAsync(x => x.Email == request.Email && x.DeletedAt == null, cancellationToken);
            if (isExist)
            {
                throw new DuplicationException("Email is existed");
            }
            isExist = await _userRepository.AnyAsync(x => x.Email == request.PhoneNumber && x.DeletedAt == null, cancellationToken);
            if (isExist)
            {
                throw new DuplicationException("Phone number is existed");
            }
            var role = await _roleRepository.FindAsync(x => x.ID == request.RoleID && x.DeletedAt == null, cancellationToken);
            if (role == null)
            {
                throw new NotFoundException("Role is not exist");
            }
            var user = new UserEntity
            {
                Address = request.Address,
                Username = request.Username,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                FullName = request.FullName,
                PasswordHash = _userRepository.HashPassword(request.Password),
                RoleID = request.RoleID,
                CreatedAt = DateTime.UtcNow,
                Point = 0,
            };
            _userRepository.Add(user);
            await _userRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return user.ID;       
        }
        
    }
}
