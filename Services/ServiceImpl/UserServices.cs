using AutoMapper;
using Azure.Core;
using BusinessObjecs.DTOs;
using BusinessObjecs.MappingExtension;
using BusinessObjecs.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        private readonly IRoleRepository _roleRepository;
        public UserServices(IUserRepository userRepository, IRoleRepository roleRepository, IMapper mapper, ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
            _mapper = mapper;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }
        public async Task<UserLoginDTO> Login(LoginDTO query, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindAsync(x => x.Email == query.Email && x.DeletedAt == null, cancellationToken);
            if (user == null)
            {
                throw new NotFoundException($"Không tìm thấy tài khoản nào với email - {query.Email}");
            }
            if (user != null)
            {
                var role = await _roleRepository.FindAsync(x => x.ID == user.RoleID && x.DeletedAt == null, cancellationToken);
                if (role == null)
                {
                    throw new NotFoundException($"Không tìm thấy tài khoản với role - {query.Email}");
                }

                var checkPassword = _userRepository.VerifyPassword(query.Password, user.PasswordHash);
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
        public async Task<UserDTO> GetUser(string id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindAsync(p=> p.ID == id && p.DeletedAt == null, cancellationToken);
            if (user == null)
            {
                throw new NotFoundException("Không tìm thấy user");
            }
            return user.MapToUserDto(_mapper);
        }

        public async Task<List<UserDTO>> GetAll(CancellationToken cancellationToken)
        {
            var userList = await _userRepository.FindAllAsync(cancellationToken);
            foreach (UserEntity user in userList)
            {
                if ( user.DeleterID != null)
                {
                    userList.Remove(user);
                }
            }
            return userList.MapToUserDtoList(_mapper);
        }

        public async Task<string> Update(string id, UserUpdateDTO request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindAsync(p => p.ID == id && p.DeletedAt == null, cancellationToken);
            if (user == null)
            {
                throw new NotFoundException("Không tìm thấy user");
            }
            if(request.FullName != null)
            {
                user.FullName = request.FullName;
            }
            if (request.PhoneNumber != null)
            {
                user.PhoneNumber = request.PhoneNumber;
            }
            if (request.Password != null)
            {
                user.PasswordHash = _userRepository.HashPassword(request.Password);
            }
            if (request.Email != null)
            {
                user.Email = request.Email;
            }
            if (request.Address != null)
            {
                user.Address = request.Address;
            }
            if (request.RoleID != null)
            {
                user.RoleID = (int)request.RoleID;
            }
            if (request.Point != null)
            {
                user.Point = (int)request.Point;
            }
            user.UpdaterID = _currentUserService.UserId;
            user.LastestUpdateAt = DateTime.Now;
            _userRepository.Update(user);
            return await _userRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Update thành công" : "Update thất bại";
        }

        public async Task<string> Delete(string id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.FindAsync(p => p.ID == id && p.DeletedAt == null, cancellationToken);
            if (user == null)
            {
                throw new NotFoundException("Không tìm thấy user");
            }
            user.DeleterID = _currentUserService.UserId;
            user.DeletedAt = DateTime.Now;
            _userRepository.Update(user);
            return await _userRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0 ? "Delete thành công" : "Delete thất bại";
        }
    }
}
