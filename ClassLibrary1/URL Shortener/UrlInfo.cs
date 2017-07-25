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

        public string RandomString()
        {
            string input = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder builder = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < 8; i++)
            {
                var ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}