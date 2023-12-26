using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_server_cloudinary.services
{
    public class FileUploadService
    {
        public string UploadedFileUrl { get; private set; }

        public void SetUploadedFileUrl(string url)
        {
            UploadedFileUrl = url;
        }
    }
}