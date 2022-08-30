using Cobi.Model.News.Commands.NewsGroup;
using CobiWebSite.API.FreameWork;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using CobiWebSite.Model.News.Entities.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CobiWebSite.API.News
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupNewsController : BaseController

    {

        public GroupNewsController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateGroupNews")]
        public async Task<IActionResult> CreateGroupNews(CreateGroup GroupNews)
        {
            var response = await _mediator.Send(GroupNews);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);



        }

        [HttpPut("UpdateGroupNews")]
        public async Task<IActionResult> UpdateGroupNews(UpdateGroup GroupNews)
        {
            var response = await _mediator.Send(GroupNews);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }




        [HttpDelete("DeleteGroupNews")]
        public async Task<IActionResult> DeleteGroupNews(DeleteGroup GroupNews)
        {
            var response = await _mediator.Send(GroupNews);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }





    }
}
