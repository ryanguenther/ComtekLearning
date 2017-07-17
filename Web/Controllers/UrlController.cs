using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
using ClassLibrary1.URL_Shortener;

namespace Web.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<UrlShortener>());
        }

        public IActionResult Create()
        {
            throw new NotImplementedException();
        }
    }
}