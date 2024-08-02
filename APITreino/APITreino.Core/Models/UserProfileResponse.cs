using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITreino.Core.Models
{
    public class UserProfileResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int PhoneNumber { get; set; }
        public UserResponse User { get; set; }

        public static UserProfileResponse mapfrommodel (UserProfile user) 
        {
            return new()
            {
                Name = user.Name,
                Surname = user.Surname,
                Birthday = user.Birthday,
                PhoneNumber = user.PhoneNumber,
                User = new()
                {
                    Email = user.User.Email,
                    Password = user.User.Password
                }
            };
        }
    }
}
