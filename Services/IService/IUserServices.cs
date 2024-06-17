using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IUserServices : IServices<UserEntity>
    {
        Task<UserLoginDTO> Login(LoginDTO query, CancellationToken cancellationToken);
        Task<string> Register(RegisterDTO request, CancellationToken cancellationToken);
    }
}
