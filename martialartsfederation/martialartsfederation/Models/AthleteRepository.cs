using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using martialartsfederation.Models;
using martialartsfederation.Data;

namespace martialartsfederation.Models
{
    public class AthleteRepository : IAthleteRepository
    {
        private readonly AppDbContext _appDbContext;

        public AthleteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Athlete> AllAthletes
        {
            get
            {
                return _appDbContext.Athletes.Include(p => p.AthleteId);
            }
        }

        public IEnumerable<Athlete> Champion
        {
            get
            {
                return _appDbContext.Athletes.Include(p => p.AthleteId).Where(p => p.IsChampion);
            }
        }

        public Athlete GetAthleteById(int AthleteId)
        {
            return _appDbContext.Athletes.FirstOrDefault(p => p.AthleteId == AthleteId);
        }
    }
}
