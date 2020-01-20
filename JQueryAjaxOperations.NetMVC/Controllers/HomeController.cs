using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryAjaxOperations.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        private List<string> liste = new List<string>() 
        {"Elif","Esra","Emir" };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }

        public PartialViewResult VerileriGetir(string veri ="")
        {
            if(string.IsNullOrEmpty(veri) == false)
            {
             liste.Add(veri);
            }
            
            System.Threading.Thread.Sleep(3000);
            return PartialView("_DataItemPartial",liste);
        }
        //public PartialViewResult VerileriGetir2(string veri)
        //{
        //    liste.Add(veri);
        //    System.Threading.Thread.Sleep(3000);
        //    return PartialView("_DataItemPartial", liste);
        //}

        public JsonResult VerileriGetir2(string veri="")
        {
            if (string.IsNullOrEmpty(veri) == false)
            {
                liste.Add(veri);
            }
            System.Threading.Thread.Sleep(2000);
            return Json(liste,JsonRequestBehavior.AllowGet);
        }
    }
}