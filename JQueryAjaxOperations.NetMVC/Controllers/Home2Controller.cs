using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryAjaxOperations.NetMVC.Controllers
{
    public class Home2Controller : Controller
    {
        //Ajax ile Dosya Yükleme
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult FileUpload(HttpPostedFileBase file)
        {
            if(file !=null)
            {
                if (Directory.Exists(Server.MapPath("~/files")) == false)
                {
                    Directory.CreateDirectory(Server.MapPath("~/files"));

                    file.SaveAs(Path.Combine(Server.MapPath("~/files"), file.FileName));

                    return Json(new { hasError = false, message = "Dosya yüklendi.." });
                }
            }
            return Json(new { hasError = true, message = "Dosya null geldi." });
        }
    }
}