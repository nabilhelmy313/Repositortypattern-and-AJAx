using Repo.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class CountryCityVM
    {
        public List<Country> Countries{ get; set; }
        public int CountryId { get; set; }
    }
}
