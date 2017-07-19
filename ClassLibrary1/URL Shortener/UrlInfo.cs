using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;
using ClassLibrary1.URL_Shortener;

namespace ClassLibrary1.URL_Shortener
{
    public class UrlInfo
    {
        public DateTime Time()
        {
            //var x = DateTime.Today.ToString("MM/dd/yyyy");
            var today = DateTime.Now;


            return today.AddDays(7);
        }

        public UrlShortener Hash()
        {


            return null;
        }
    }
}