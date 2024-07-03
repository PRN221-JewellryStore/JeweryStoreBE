using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.MappingExtension
{
    public static class UserMappingExtension
    {
        public static UserDTO MapToUserDto(this UserEntity projectFrom, IMapper mapper)
            => mapper.Map<UserDTO>(projectFrom);
        public static List<UserDTO> MapToUserDtoList(this IEnumerable<UserEntity> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToUserDto(mapper)).ToList();
    }
}
