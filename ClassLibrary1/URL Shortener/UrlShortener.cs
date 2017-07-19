using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;
using ClassLibrary1.URL_Shortener;

namespace ClassLibrary1.URL_Shortener
{
    public class UrlShortener
    {
        public string OriginalUrl { get; set; }
        public string Hash { get; set; }
        public DateTime Expiry { get; set; }
    }
}
