using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpLoadImage.Controllers
{
    public class Upload
    {
        public static void UploadImage()
        {
            Account account = new Account(
          "my_cloud_name",
          "my_api_key",
          "my_api_secret");

            Cloudinary cloudinary = new Cloudinary(account);
        }
        
    }
}