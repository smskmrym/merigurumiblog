﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using merigurumi.blog.WebApi.Enams;
using merigurumi.blog.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace merigurumi.blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public async Task<UploadModel> UploadFile(IFormFile file, string contentType)
        {
            UploadModel uploadModel = new UploadModel();
            if (file.ContentType != null)
            {
                if (file.ContentType != contentType)
                {
                    uploadModel.ErrorMessage = "desteklenmeyen dosya türü";
                    uploadModel.UploadState = UploadState.Error;
                    return uploadModel;
                }
                else
                {
                    var newName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image" + newName);
                    var stream = new FileStream(path, FileMode.Create);
                    await file.CopyToAsync(stream);

                    uploadModel.NewName = newName;
                    uploadModel.UploadState = UploadState.Success;
                    return uploadModel;

                }
            }
            uploadModel.ErrorMessage = "Dosya Yok";
            uploadModel.UploadState = UploadState.NotExist;
            return uploadModel;

        }
    }
}