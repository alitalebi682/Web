//using Cobi.Model.News.Commands.NewsImage;
//using Cobi.Model.News.Entities.Dtos;
//using Cobi.Model.News.Entities.Queries;
//using CobiWebSite.API.FreameWork;
//using CobiWebSite.Model.News.Entities;
//using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Linq;
//using System.Reflection;

//namespace WebApiUi.News
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ImageNewsController : BaseController
//    {

//        public ImageNewsController(IMediator mediator) :base(mediator)
//        {

//        }
//        [HttpPost("Images")]
//        public async Task<IActionResult> UploadImages(IList<IFormFile> formFiles)
//        {
//            var uploadImagesCommand = new CreateImage();

//            foreach (var formFile in formFiles)
//            {
//                var file = new FileDto
//                {
//                    Content = formFile.OpenReadStream(),
//                    Name = formFile.FileName,
//                    ContentType = formFile.ContentType,
//                };
//                //uploadImagesCommand.Files.Add(file);
//            }

//            var response = await _mediator.Send(uploadImagesCommand);

//            if (response.IsSuccess)
//            {
//                return Ok(response.Result);
//            }
//            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);

//        }

//    }
//}
