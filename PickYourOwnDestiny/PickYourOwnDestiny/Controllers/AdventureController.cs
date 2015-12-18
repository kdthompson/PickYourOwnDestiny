using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PickYourOwnAdventure.Controllers
{
    public class AdventureController : Controller
    {
        //
        // GET: /Adventure/
        public ActionResult Index()
        {
            return View();
        }
	}
}