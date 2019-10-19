using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace martialartsfederation.Models
{
    public class AppDbContext : IndentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Academy> Academies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Athlete>().HasData(new Athlete
            {
                AthleteId = 1,
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
                Email = "arobles@mafederation.com"


            });
        }
    }
}
