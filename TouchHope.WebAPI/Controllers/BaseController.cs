// Çağatay Akdeniz //
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TouchHope.WebApi.Models;
using TouchHope.WebAPI.Enums;

namespace TouchHope.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public async Task<UploadModel> UploadFileAsync(IFormFile file, string contentType)
        {
            UploadModel uploadModel = new UploadModel();
            if(file!=null)
            {
                if(file.ContentType!=contentType)
                {
                    uploadModel.UploadState = UploadState.Error;
                    uploadModel.ErrorMessage = "Hatalı dosya türü";
                    return uploadModel;
                }
                else
                {
                    string newName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    //var path = Path.Combine(@"C:\Users\User\Documents\C#Projects\TouchHope\TouchHope.WebUI", "wwwroot/img/" + newName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newName);
                    var stream = new FileStream(path, FileMode.Create);
                    await file.CopyToAsync(stream);

                    uploadModel.newName = newName;
                    uploadModel.UploadState = UploadState.Success;
                    return uploadModel;
                }
            }
            uploadModel.UploadState = UploadState.NotExist;
            return uploadModel;
        }
    }
}// Çağatay Akdeniz //