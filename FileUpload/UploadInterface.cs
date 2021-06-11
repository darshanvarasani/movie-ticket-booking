using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload
{
    public interface UploadInterface
    {

        void uploadfilemultiple(IList<IFormFile> files);
    }
}
