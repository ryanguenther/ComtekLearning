using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.URL_Shortener
{
    interface IUrlInfo
    {
        UrlShortener Update(int ID, UrlShortener save);

        UrlShortener GetUrlById(int ID);

        List<UrlShortener> GetUrls();
    }
}
