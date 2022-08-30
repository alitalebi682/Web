using Cobi.Model.News.Commands.NewsRelated;
using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.BLL.News.Commands.NewsRelated
{
    public class DeleteRelatedHandler : BaseApplicationServiceHandler<DeleteRelated, NewseRelated>
    {
        public DeleteRelatedHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(DeleteRelated request, CancellationToken cancellationToken)
        {
            var NewsRelated = await _CobiWebSiteDbContext.NewsRelateds.Where(a => a.Id == request.Id).FirstOrDefaultAsync();


            if (NewsRelated == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                _CobiWebSiteDbContext.NewsRelateds.Remove(NewsRelated);
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsRelated);
            }
        }
    }
}
