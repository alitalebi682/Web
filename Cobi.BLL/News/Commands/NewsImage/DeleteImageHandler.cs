using Cobi.Model.News.Commands.NewsImage;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.BLL.News.Commands
{
    public class DeleteImageHandler : BaseApplicationServiceHandler<DeleteImage, SingleUploadFile>
    {
        public DeleteImageHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override Task HandleRequest(DeleteImage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}

