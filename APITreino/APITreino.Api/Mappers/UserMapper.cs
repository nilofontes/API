using APITreino.Api.Dto;
using APITreino.Core.Models;
using AutoMapper;

namespace APITreino.Api.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper() 
        {
            CreateMap<UserDto, User>();
            CreateMap<User,UserDto>();

        }
    }
}
