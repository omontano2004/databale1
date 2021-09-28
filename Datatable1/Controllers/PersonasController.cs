using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Datatable1.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}