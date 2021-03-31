using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repo.Models;
using Repo.Models.Data;
using Repo.Models.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepoProj<City> cityRepo;

        public HomeController(IRepoProj<City> cityRepo)
        {
            this.cityRepo = cityRepo;
        }

        public IActionResult Index()
        {
            var model = cityRepo.List();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

            
    }
}
