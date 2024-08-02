using APITreino.Core.Models;

namespace APITreino.Api.Dto
{
    public class UserProfileDto 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int PhoneNumber { get; set; }
        public int UserId { get; set; }
    }
}
