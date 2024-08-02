using APITreino.Api.Dto;
using APITreino.Core.Models;
using APITreino.Infrastructure.Database;
using APITreino.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APITreino.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : BaseController<UserProfileDto, UserProfile, UserProfileRepository>
    {

        public UserProfileController(IMapper mapper) : base(mapper) { }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarProfiles()
        {
            using (ApiContext context = new ApiContext())
            {
                var profiles = await context.Set<UserProfile>().Include(x => x.User).ToListAsync();
                return Ok(profiles.Select(x => UserProfileResponse.mapfrommodel(x)));
            }
            
        }
    }
    
}
