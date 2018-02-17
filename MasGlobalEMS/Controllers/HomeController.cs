using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasGlobalEMSCore;
using MasGlobalEMSBL;
using MasGlobalEmpInfra;
using System.Collections;
namespace MasGlobalEMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
       
    }
}
