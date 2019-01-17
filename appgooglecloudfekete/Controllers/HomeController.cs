using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appgooglecloudfekete.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            _log.Debug("Home page hit!");
            return View();
        }

      //  public ActionResult About()
      //  {
        //    ViewBag.Message = "Your application description page.";
      //  } -->

     //   public ActionResult Contact()
      //  {
        //    ViewBag.Message = "Your contact page.";
       //     return View();
      //  }
        public ActionResult Create()
        {
            ViewBag.Message = "Your create page.";
            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.Message = "Your Edit page.";
            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Message = "Your Details page.";
            return View();
        }
        public ActionResult Delete()
        {
            ViewBag.Message = "Your Details page.";
            return View();
        }
    }
}