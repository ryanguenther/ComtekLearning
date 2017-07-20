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
            var url = new UrlInfo();
            var time = url.Time();

            var urlclass = new UrlShortener();

            //var useurl = urlclass.OriginalUrl;

            return View(new List<UrlShortener>
            {
                new UrlShortener
                {
                    Expiry = time,
                    Hash = "I am a hash",
                    OriginalUrl = urlclass.OriginalUrl //useurl
                },

                /*
                new UrlShortener
                {
                    Expiry = "tomorrow",
                    Hash = "I am a hash2",
                    OriginalUrl = "REALLY LONG URL2"
                },
                */

            });
        }

        [HttpPost]
        public IActionResult Index(UrlShortener save)
        {
            var urlsave = new UrlInfo();
            urlsave.Save(save.ID, save);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Create()
        {
            throw new NotImplementedException();
        }
    }
}