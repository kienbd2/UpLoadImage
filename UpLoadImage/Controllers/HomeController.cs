using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UpLoadImage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            Account account = new Account(
           "dev2020",
           "247996535991499",
           "9jI_5YjJaseBKUrY929sUtt0Fy0");
            //MemoryStream ms = new MemoryStream();
            //ms = new MemoryStream(file.fi)
            string pic = Path.GetFileName(file.FileName);
            string path = Path.Combine(Server.MapPath("Images"), Path.GetFileName(file.FileName));
      
            
            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(path, file.InputStream),
            };
            var uploadResult = cloudinary.Upload(uploadParams);
             var ruta = uploadResult.SecureUrl.ToString();
            return View();
        }
       
        public ActionResult About()
        {

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}