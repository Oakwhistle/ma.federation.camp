using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using martialartsfederation.Models;

namespace martialartsfederation.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Academy> Academies { get; set; }
        //public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Academy>().ToTable("Academy");
            modelBuilder.Entity<Athlete>().ToTable("Athlete");
            //modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
