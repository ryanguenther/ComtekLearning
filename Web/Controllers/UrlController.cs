using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.URL_Shortener;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Web.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            var urlpage = new UrlInfo();
            var newurl = urlpage.GetUrls();
            return View(newurl);
        }

        public IActionResult Edit(int ID)
        {
            var url = new UrlInfo();
            var urlshort = url.GetUrlById(ID);
            return View(urlshort);
        }

        [HttpPost]
        public IActionResult Edit(UrlShortener save)
        {
            var urlsave = new UrlInfo();
            urlsave.Update(save.ID, save);
            return RedirectToAction("Index", "Url");
        }

        public IActionResult UrlOriginal(int ID)
        {
            var url = new UrlInfo();
            var urlshort = url.GetUrlById(ID);
            return View(urlshort);
        }

        [HttpPost]
        public IActionResult UrlOriginal(UrlShortener model)
        {
            var urlsave = new UrlInfo();
            urlsave.Create(model);
            return RedirectToAction("Index", "Url");
        }
    }
}