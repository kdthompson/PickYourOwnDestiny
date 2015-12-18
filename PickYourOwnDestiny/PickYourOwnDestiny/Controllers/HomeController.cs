using PickYourOwnAdventure.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PickYourOwnDestiny.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Adventure()
        {
            ViewBag.Message = "Your Adventure";

            //get the files in the Content/Images folder

            var path = Server.MapPath("../Content/Images/");
            //Get the dir names
            var dirs = Directory.GetDirectories(path);

            var vmg = new CharacterImageDirs();
            vmg.dirs = new List<Dir>();

            foreach (var dirItem in dirs)
            {
                //go through dir's

                //Create the list to fill
                var fileList = new List<string>();

                var dir = new Dir();
                dir.name = Path.GetFileName(dirItem);
                dir.images = new List<CharacterImage>();
                var files = Directory.GetFiles(path + "/" + dir.name, "*.*");
                foreach (var file in files)
                {
                    var image = new CharacterImage();
                    image.name = Path.GetFileName(file);
                    dir.images.Add(image);
                }
                vmg.dirs.Add(dir);
            }

            return View(vmg);
        }
    }
}