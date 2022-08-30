using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Commands.NewsGroup
{
    public class DeleteGroup :IRequest<ApplicationServiceResponse<GroupNews>>
    {
        public int Id { get; set; }
    public string GroupNewsName { get; set; }

   
}
}
   
   
