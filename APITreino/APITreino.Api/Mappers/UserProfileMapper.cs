using APITreino.Api.Dto;
using APITreino.Core.Models;
using AutoMapper;

namespace APITreino.Api.Mappers
{
    public class UserProfileMapper
    {
        public class UserMapper : Profile
        {
            public UserMapper()
            {
                CreateMap<UserProfileDto, UserProfile>();
                CreateMap<UserProfile, UserProfileDto>();

            }
        }
    }
}
