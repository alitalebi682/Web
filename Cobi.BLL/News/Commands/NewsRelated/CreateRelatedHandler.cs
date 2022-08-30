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
    public class CreateRelatedHandler : BaseApplicationServiceHandler<CreateRelated, NewseRelated>
    {
        public CreateRelatedHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateRelated request, CancellationToken cancellationToken)
        {
            NewseRelated NewseRelated = new()
            {


                NewsRelatedName = request.NewsRelatedName,






            };
            await _CobiWebSiteDbContext.NewsRelateds.AddAsync(NewseRelated);
            await _CobiWebSiteDbContext.SaveChangesAsync();
            AddRsult(NewseRelated);
        }
    }
}
