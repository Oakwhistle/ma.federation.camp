using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using martialartsfederation.Data;

namespace martialartsfederation.Models
{
    public enum Belt
    {
        Wwhite, Blue, Purple, Brown, Black
    }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int AcademyId { get; set; }
        public int AthleteId { get; set; }
        public Belt? Belt { get; set; }
        public Academy Academy { get; set; }
        public Athlete Athlete { get; set; }
    }
}
