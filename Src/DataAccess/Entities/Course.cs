using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Tee { get; set; }
        public string UsgaRating { get; set; }
        public string Slope { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string BogeyRating { get; set; }
    }
}
