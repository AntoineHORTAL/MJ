using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJ.Controllers
{
    public class JDRController : Controller
    {
        public ActionResult Avatar()
        {
            return View("~/Views/JDR/Avatar/Avatar.cshtml");
        }

        public ActionResult Alien() 
        {
            return View("~/Views/JDR/Alien/Alien.cshtml");
        }

        public ActionResult WrathAndGLory() 
        {
            return View("~/Views/JDR/WrathAndGlory/WrathAndGlory.cshtml");
        }

        public ActionResult TheWalkingDead() 
        {
            return View("~/Views/JDR/TheWalkingDead/TheWalkingDead.cshtml");
        }

        public ActionResult CthulhuHack() 
        {
            return View("~/Views/JDR/CthulhuHack/CthulhuHack.cshtml");
        }
    }
}