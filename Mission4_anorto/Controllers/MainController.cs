using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4_anorto.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_anorto.Controllers
{
    public class MainController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculator grades)
        {
            return View();
        }
    }
}
