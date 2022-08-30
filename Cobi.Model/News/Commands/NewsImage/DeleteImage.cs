using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Commands.NewsImage
{
    public class DeleteImage : IRequest<ApplicationServiceResponse<SingleUploadFile>>
    {
        public int Id { get; set; }
        public string ImageNewsURL { get; set; }
        public String FileName { get; set; }

    }
}
