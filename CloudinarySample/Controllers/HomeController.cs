using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudinarySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Account account = new Account(
            //                      "dbjcxfdww",
            //                      "381272371479447",
            //                      "yD8g2rFxnHMquFNwvN3iDwHNTUM");

            //Cloudinary cloudinary = new Cloudinary(account);

            //var uploadParams = new ImageUploadParams()
            //{
            //    File = new FileDescription(@"d:\mypicture.jpg")
            //};

            //var uploadResult = cloudinary.Upload(uploadParams);

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