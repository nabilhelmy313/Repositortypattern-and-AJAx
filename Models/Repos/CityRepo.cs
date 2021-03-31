using Microsoft.EntityFrameworkCore;
using Repo.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.Models.Repos
{
    public class CityRepo : IRepoProj<City>
    {
        private readonly AppDbConext conext;

        public CityRepo(AppDbConext conext)
        {
            this.conext = conext;
        }

        public City Find(int Id)
        {
            var c = conext.Cities.Find(Id);
            return c;
        }

        public List<City> List()
        {
           var x= conext.Cities.Include(c=>c.Country).ToList();
            return x;
        }

        public List<City> ListByFilter(Func<City, bool> lamda)
        {
            var x = conext.Cities.Where(lamda).ToList();
            return x;
        }
    }
}
