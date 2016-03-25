using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
   public class Potato
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Handicap { get; set; }
        public string Bio { get; set; }
        public string ProfilePicture { get; set; }
        public Leagues Leagues { get; set; }
        public Scores Scores { get; set; }

    }
}
