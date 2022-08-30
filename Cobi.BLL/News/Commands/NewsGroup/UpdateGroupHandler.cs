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
    public class UpdateGroupHandler : BaseApplicationServiceHandler<UpdateGroup, GroupNews>
    {
        public UpdateGroupHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(UpdateGroup request, CancellationToken cancellationToken)
        {
            GroupNews GroupNews = _CobiWebSiteDbContext.GroupNews.SingleOrDefault(C => C.Id == request.GroupNewsId);

            if (GroupNews == null)
            {
                AddError($"با شناسه{request.GroupNewsId} یافت نشد ");
            }
            else
            {
                {

                    
                    GroupNews.GroupNewsName = request.GroupNewsName;


                }

                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(GroupNews);
            }
        }
    }
}
