using Cobi.Model.News.Commands.News;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.BLL.News.Commands.News
{
    public class CreateNewsHandler : BaseApplicationServiceHandler<CreateNews, NewsBase>
    {
        public CreateNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateNews request, CancellationToken cancellationToken)
        {
            NewsBase NewsBase = new()
            {

                Type = request.Type,
                Description = request.Description,
                AttachpicturemainUrl = request.AttachpicturemainUrl,
                AttachpicturesUrl = request.AttachpicturesUrl,

                Keywordnews = request.Keywordnews,
                IsActive = request.IsActive,

                Enddate = request.Enddate,

                Mainnews = request.Mainnews,

                Showprofile = request.Showprofile,

                Slectnews = request.Slectnews,
                Rowtitle = request.Rowtitle,
                Rowmainnews = request.Rowmainnews,
                Showpriority = request.Showpriority,
                Startdate = request.Startdate,

                GroupNews = request.GroupNews,

                NewseRelated = request.NewseRelated,
                TypeNewsBase = request.TypeNewsBase,
                //GroupNewsId=request.GroupNewsId,


            };
            await _CobiWebSiteDbContext.NewsBases.AddAsync(NewsBase);
            await _CobiWebSiteDbContext.SaveChangesAsync();
            AddRsult(NewsBase);
        }
    }
}
