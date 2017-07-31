using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.URL_Shortener;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    //[Route("/s")]
    public class ShortRedirerctController : Controller
    {
        [Route("s/{hash}")]
        public void Redirect2(string hash)
        {
            var shrt = new UrlShortener();
            Response.Redirect(shrt.OriginalUrl);
        }
    }
}
