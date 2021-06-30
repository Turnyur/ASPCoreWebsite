using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
           
        }

        public IActionResult Article()
        {
            return View();

        }
        public IActionResult Terms()
        {
            return View();

        }

        public IActionResult Privacy()
        {
            return View();

        }



    }
}
