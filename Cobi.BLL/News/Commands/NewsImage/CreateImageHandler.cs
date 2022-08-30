using Cobi.Model.News.Commands.NewsImage;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.BLL.News.Commands.NewsImage
{
    public class CreateImageHandler : BaseApplicationServiceHandler<CreateImage, SingleUploadFile>
    {
        public CreateImageHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateImage request, CancellationToken cancellationToken)
        {
            SingleUploadFile singleUploadFile = new()
            {
                FileName=request.ToString(),
            };


            await _CobiWebSiteDbContext.SingleUploadFiles.AddAsync(singleUploadFile);
            await _CobiWebSiteDbContext.SaveChangesAsync();

            AddRsult(singleUploadFile);

            
        }
    }
}