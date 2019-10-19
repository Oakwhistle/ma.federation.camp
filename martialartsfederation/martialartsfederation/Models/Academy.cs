using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using martialartsfederation.Data;

namespace martialartsfederation.Models
{
    public class Academy
    {
        public int AcademyId { get; set; }

        public string Name { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
