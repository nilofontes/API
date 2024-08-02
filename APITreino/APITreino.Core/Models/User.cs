namespace APITreino.Core.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual UserProfile Profile { get; set; }

    }
}
