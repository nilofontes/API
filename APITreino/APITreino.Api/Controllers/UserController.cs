using APITreino.Api.Dto;
using APITreino.Core.Models;
using APITreino.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITreino.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<UserDto, User, UserRepository>
    {
        public UserController(IMapper mapper) : base(mapper) { }
    }
}
