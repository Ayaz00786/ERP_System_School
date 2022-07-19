using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Areas.Students.Controllers
{
    public class StudentsAreasController : Controller
    {
        [Area("Students")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
