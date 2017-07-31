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

        //GetUrlByHash

        public UrlShortener GetUrlById(int ID)
        {
            var listOfUrls = GetUrls();
            var url = listOfUrls.FirstOrDefault(save => save.ID == ID);

            return url;
        }

        public UrlShortener Update(int ID, UrlShortener save)
        {
            var update = GetUrlById(ID);
            update.OriginalUrl = save.OriginalUrl;
            update.Hash = save.Hash;

            return update;
        }

        public UrlShortener Create(UrlShortener model)
        {
            MockUrlDB.urls.Add(model);
 
            model.Hash = RandomHash();
            model.Expiry = DateTime.Now.AddDays(7);

            return model;
        }

        public string RandomHash()
        {
            string input = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder hashbuilder = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < 8; i++)
            {
                var hash = input[random.Next(0, input.Length)];
                hashbuilder.Append(hash);
            }
            return hashbuilder.ToString();
        }
    }
}