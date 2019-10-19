using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace martialartsfederation.Models
{
    public class Athlete : Person
    {
        public int AthleteId { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        public string CountryofResidence { get; set; }

        [Required]
        public int Phone { get; set; }
        [Required]
        public string Belt { get; set; }
        [Required]
        public string Academy { get; set; }
        [Required]
        public string Professor { get; set; }

        public bool IsChampion { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
