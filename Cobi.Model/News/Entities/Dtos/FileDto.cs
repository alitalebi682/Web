using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Entities.Dtos
{
    public class FileDto
    {

        public Stream Content { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
    }
}
