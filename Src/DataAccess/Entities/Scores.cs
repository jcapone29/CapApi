using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Scores
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public string Course { get; set; }
        public DateTime RoundDate {get; set;}

    }
}
