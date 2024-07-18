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

        Task<UserDTO> GetUser(string id, CancellationToken cancellationToken);

        Task<List<UserDTO>> GetAll(CancellationToken cancellationToken);

        Task<string> Update(string id, UserUpdateDTO dto, CancellationToken cancellationToken);
        Task<string> Delete(string id, CancellationToken cancellationToken);

        Task SendEmailCustomer(string email, CancellationToken cancellationToken );

    }
}
