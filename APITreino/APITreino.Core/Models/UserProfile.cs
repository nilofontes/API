using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITreino.Core.Models
{
    public class UserProfile : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int PhoneNumber { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}
