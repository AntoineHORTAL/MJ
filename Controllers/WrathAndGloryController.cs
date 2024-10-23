using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MJ.Controllers
{
    public class WrathAndGloryController : Controller
    {
        public ActionResult Avachrus()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        
        public ActionResult EmployeursListe()
        {
            return View("~/Views/JDR/WrathAndGlory/EmployeursList.cshtml");
        }
    }
}