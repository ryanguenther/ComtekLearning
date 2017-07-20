using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using ClassLibrary1.URL_Shortener;

namespace ClassLibrary1.URL_Shortener
{
    public class UrlInfo : IUrlInfo
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

        public List<UrlShortener> GetUrls()
        {
            var urllist = MockUrlDB.urls;
            return urllist;
        }

        public UrlShortener GetUrlById(int ID)
        {
            var listOfUrls = GetUrls();
            var url = listOfUrls.FirstOrDefault(save => save.ID == ID);

            return url;
        }

        public UrlShortener Save(int ID, UrlShortener save)
        {
            var update = GetUrlById(ID);
            update.OriginalUrl = save.OriginalUrl;

            return update;
        }
    }
}