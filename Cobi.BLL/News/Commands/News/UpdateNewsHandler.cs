﻿using Cobi.Model.News.Commands.News;
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
    public class UpdateNewsHandler : BaseApplicationServiceHandler<UpdateNews, NewsBase>
    {
        public UpdateNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(UpdateNews request, CancellationToken cancellationToken)
        {
            NewsBase NewsBase = _CobiWebSiteDbContext.NewsBases.SingleOrDefault(C => C.Id == request.Id);

            if (NewsBase == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                {

                    NewsBase.Type = request.Type;
                    NewsBase.AttachpicturemainUrl = request.AttachpicturemainUrl;
                    NewsBase.AttachpicturesUrl = request.AttachpicturesUrl;
                    NewsBase.Rowmainnews = request.Rowmainnews;
                    NewsBase.Rowtitle = request.Rowtitle;


                }

                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsBase);
            }
        }
    }
}
