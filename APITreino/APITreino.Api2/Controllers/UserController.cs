using APITreino.Api2.Context;
using APITreino.Api2.Dto;
using APITreino.Api2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace APITreino.Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(UserDto model)
        {
            User user = new User();
            user.Email = model.Email;
            user.Password = model.Password;
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;
            using (ApiContext context = new ApiContext())
            {
                context.Add(user);
                context.SaveChanges();
            }
            return Ok(model);
        }

        [HttpGet]
        public string ListAll()
        {
            return "teste";
        }
    }
}
