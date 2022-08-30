﻿using CobiWebSite.Model.News.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CobiWebSite.API.News
{
    //[Consumes("application/json")]
    [Route("api/[controller]/UploadFile")]
    [ApiController]
    public class SingleFileController : ControllerBase
    {




        [Route("api/Upload")]
        [HttpPost]
        public IActionResult Upload([FromForm] SingleUploadFile model)
        {
            if (ModelState.IsValid)
            {


                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images");

                //create folder if not exist
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                //get file extension
                FileInfo fileInfo = new FileInfo(model.File.FileName);
                string fileName = model.FileName + fileInfo.Extension;

                string fileNameWithPath = Path.Combine(path, fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    model.File.CopyTo(stream);
                }

            }
            return Ok();
        }

    }
}
