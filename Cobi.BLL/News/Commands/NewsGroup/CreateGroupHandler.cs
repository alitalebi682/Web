using Cobi.Model.News.Commands.NewsGroup;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.BLL.News.Commands.NewsGroup
{
    public class CreateGroupHandler : BaseApplicationServiceHandler<CreateGroup, GroupNews>
    {
        public CreateGroupHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateGroup request, CancellationToken cancellationToken)
        {
            GroupNews GroupNews = new()
            {



                GroupNewsName = request.GroupNewsName,







            };
            await _CobiWebSiteDbContext.GroupNews.AddAsync(GroupNews);
            await _CobiWebSiteDbContext.SaveChangesAsync();
            AddRsult (GroupNews);
        }
    }
}
 