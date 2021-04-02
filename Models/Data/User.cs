using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.Models.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
    }
}
