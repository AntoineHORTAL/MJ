﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJ.Models.WrathAndGlory;

namespace MJ.Controllers
{
    public class WrathAndGloryController : Controller
    {
        #region Système Gilead
        public ActionResult Avachrus()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult Nethreus()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult Ostia()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult Enoch()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult GileadPrimus()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult Charibdion()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult BourbierDuVide()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult PersephonesRegret()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult Vulkaris()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        public ActionResult Trollius()
        {
            return View("~/Views/JDR/WrathAndGlory/Systeme_Gilead/Avachrus.cshtml");
        }
        #endregion


        public ActionResult EmployeursListe()
        {
            return View("~/Views/JDR/WrathAndGlory/EmployeursList.cshtml");
        }

        public ActionResult Bestiaire()
        {
            CreatureService _creatureservice = new CreatureService();

            List<Creature__WAG> listecreature = _creatureservice.GetListeCreature();

            listecreature = listecreature.OrderBy(c => c.Race).ToList();

            return View("~/Views/JDR/WrathAndGlory/Bestiaire.cshtml", listecreature);
        }
    }
}