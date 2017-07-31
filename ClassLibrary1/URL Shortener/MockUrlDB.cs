using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1.URL_Shortener
{
    public static class MockUrlDB
    {
        public static List<UrlShortener> urls = new List<UrlShortener>
        {
           /* new UrlShortener()
            {
                OriginalUrl = "https://",
                Hash = "",
                Expiry = DateTime.Now.AddDays(7),
                ID = 1
            },*/

            /*new UrlShortener()
            {
                OriginalUrl = "https://",
                Hash = "",
                Expiry = DateTime.Now.AddDays(7),
                ID = 2
            }*/
        };
    }
}
