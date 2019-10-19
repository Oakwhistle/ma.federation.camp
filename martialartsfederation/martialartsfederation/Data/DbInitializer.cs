using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using martialartsfederation.Data;
using martialartsfederation.Models;

namespace martialartsfederation.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Athletes.Any())
            {
                return;
            }

            var athletes = new Athlete[]
            {
                new Athlete {AthleteId = 1,
                FirstMidName = "Angel",
                LastName = "Robles",
                BirthDate = DateTime.Parse("06/29/1995"),
                Address = "Calle San Justo",
                City = "Salamanca",
                State = "Castilla y Leon",
                ZipCode = 37007,
                CountryofResidence = "Spain",
                Phone = 667000000,
                Belt = "White",
                Academy = "MartialApps",
                Professor = "Douglas",
                IsChampion = false,
                Email = "arobles@mafederation.com",
                Password = "martialapps",
                Nationality = "Venezuela",
                Gender = "Male",}
            };

            foreach (Athlete a in athletes)
            {
                context.Athletes.Add(a);
            }
            context.SaveChanges();

            var academies = new Academy[]
            {
                new Academy { AcademyId = 1,
                Name = "MartialApps",}
            };

            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    AthleteId = athletes.Single(s => s.LastName == "Robles").AthleteId,
                    AcademyId = academies.Single(c => c.Name == "MartialApps").AcademyId,
                    Belt = Belt.Wwhite
                }
            };
        }
    }
}
