﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.URL_Shortener
{
    interface IUrlInfo
    {
        UrlShortener Save(int ID, UrlShortener url);

        UrlShortener GetUrlById(int ID);

        List<UrlShortener> GetUrls();
    }
}
