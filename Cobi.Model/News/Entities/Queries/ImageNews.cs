using Cobi.Model.News.Entities.Dtos;
using CobiWebSite.Model.FrameWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Entities.Queries
{
    internal class ImageNews : IRequest<ApplicationServiceResponse<List<ImageUploadDto>>>
    {
        public string ImageNewsURL { get; set; }
    }
}
