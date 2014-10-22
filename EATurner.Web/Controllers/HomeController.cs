using EATurner.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EATurner.Web.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Home Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = new HomePageModel();

#if(DEBUG)
            model.IsDebugMode = true;
#endif

            return View(model);
        }
    }
}