using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Commands.NewsRelated
{
    public class DeleteRelated : IRequest<ApplicationServiceResponse<NewseRelated>>
    {
        public int Id { get; set; }
        public string GroupNewsName { get; set; }

        public string PictureGroupNews { get; set; }
    }
}


