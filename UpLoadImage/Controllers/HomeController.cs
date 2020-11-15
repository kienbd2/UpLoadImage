using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        public ActionResult Index(HttpPostedFileBase file2)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { result = false, mess = "Not valid" });
            }
            var lstImage = new List<string>();
            HttpFileCollectionBase files = Request.Files;
            if (files.Count > 5)
            {
                return Json(new { result = false, mess = "Không up lớn hơn 5 ảnh", url = Url.Action("Index", "Apartment") });
            }

            Task task = Task.Run(async () =>
            {
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase file = files[i];
                    Account account = new Account("dev2020", "247996535991499", "9jI_5YjJaseBKUrY929sUtt0Fy0");

                    string path = Path.Combine(Server.MapPath("Images"), Path.GetFileName(file.FileName));
                    Cloudinary cloudinary = new Cloudinary(account);
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(path, file.InputStream),
                    };
                    var uploadResult = await cloudinary.UploadAsync(uploadParams);
                    lstImage.Add(uploadResult.SecureUrl.ToString());
                }
            });
            task.Wait();
            return Json(new { result = true, url = Url.Action("Index", "Apartment") });
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