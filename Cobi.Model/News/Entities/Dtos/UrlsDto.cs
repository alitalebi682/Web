﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Entities.Queries
{
    public class UrlsDto
    {
        public ICollection<string> Urls { get; }

        public UrlsDto(ICollection<string> urls)
        {
            Urls = urls;
        }
    }
}
