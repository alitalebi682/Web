using Cobi.Model.News.Commands.NewsGroup;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.BLL.News.Commands.NewsGroup
{
    public class DeleteGroupHandler : BaseApplicationServiceHandler<DeleteGroup, GroupNews>
    {
        public DeleteGroupHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(DeleteGroup request, CancellationToken cancellationToken)
        {
            var GroupNews = await _CobiWebSiteDbContext.GroupNews.Where(a => a.Id == request.Id).FirstOrDefaultAsync();


            if (GroupNews == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                _CobiWebSiteDbContext.GroupNews.Remove(GroupNews);
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(GroupNews);
            }
        }
    }
}


