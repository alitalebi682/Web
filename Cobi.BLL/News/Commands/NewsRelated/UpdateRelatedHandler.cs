using Cobi.Model.News.Commands.NewsRelated;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.BLL.News.Commands.NewsRelated
{
    public class UpdateRelatedHandler : BaseApplicationServiceHandler<UpdateRelated, NewseRelated>
    {
        public UpdateRelatedHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(UpdateRelated request, CancellationToken cancellationToken)
        {
            NewseRelated NewsRelated = _CobiWebSiteDbContext.NewsRelateds.SingleOrDefault(C => C.Id == request.Id);

            if (NewsRelated == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                {


                    NewsRelated.NewsRelatedName = request.NewsRelatedName;


                }

                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsRelated);
            }
        }
    }
}
