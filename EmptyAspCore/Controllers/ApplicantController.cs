using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Controllers
{
    public class ApplicantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
