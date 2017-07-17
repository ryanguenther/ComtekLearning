using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult UrlShortener()
        {
            return View();
        }
    }
}