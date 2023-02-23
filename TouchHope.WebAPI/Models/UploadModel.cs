using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebAPI.Enums;

namespace TouchHope.WebApi.Models
{
    public class UploadModel
    {
        public string newName { get; set; }
        public string ErrorMessage { get; set; }
        public UploadState UploadState { get; set; }
    }
}
