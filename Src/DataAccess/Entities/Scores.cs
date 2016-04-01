using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Scores
    {
        public Potato UserId { get; set; }
        public int Score { get; set; }
        public Course Course { get; set; }
        public DateTime RoundDate {get; set;}

    }
}
