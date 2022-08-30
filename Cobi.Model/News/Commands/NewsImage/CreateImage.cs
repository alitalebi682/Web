using Cobi.Model.News.Entities.Dtos;
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
    public class CreateImage : IRequest<ApplicationServiceResponse<SingleUploadFile>>
    {

        public string ImageNewsURL { get; set; }
        public int Id { get; set; }
    }
}
