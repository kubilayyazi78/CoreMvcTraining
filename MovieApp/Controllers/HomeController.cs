using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
