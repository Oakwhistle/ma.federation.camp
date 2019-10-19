using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using martialartsfederation.Data;

namespace martialartsfederation.Models
{
    public class IAthleteRepository
    {
        IEnumerable<Athlete> AllAthletes { get; }
        IEnumerable<Athlete> Champions { get; }
        //Athlete GetAthleteById(int AthleteId);
    }
}
