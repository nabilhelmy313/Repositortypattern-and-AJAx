using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo.Models.Data;
using Repo.Models.Repos;
using Repo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.Controllers
{
    public class AjaxController : Controller
    {
        private readonly IRepoProj<Country> country;
        private readonly IRepoProj<City> city;

        public AjaxController(IRepoProj<Country> country,IRepoProj<City> city)
        {
            this.country = country;
            this.city = city;
        }
        public IActionResult Index()
        {
            CountryCityVM vM = new CountryCityVM
            {
                Countries = country.List(),
            };
            return View(vM);
        }
        public JsonResult GetCities(int CountryId)
        {
            var c = country.Find(CountryId);
            var cit = city.ListByFilter(cc => cc.Country == c);
            return Json(new SelectList(cit,"Id","Name"));
        }
    }
}
