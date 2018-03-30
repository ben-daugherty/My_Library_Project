using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mybrary.Controllers
{
    public class LibraryController : Controller
    {
        //Returning the View for Index on the main page

        public ActionResult Index()
        {
            return View();
        }
    }
        
}