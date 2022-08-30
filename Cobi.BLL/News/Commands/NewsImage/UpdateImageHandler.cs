using Cobi.Model.News.Commands.NewsImage;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.BLL.News.Commands
{
    public class UpdateImageHandler : BaseApplicationServiceHandler<UpdateImage, SingleUploadFile>
    {
        public UpdateImageHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override Task HandleRequest(UpdateImage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}


