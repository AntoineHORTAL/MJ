using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MJ.Models.WrathAndGlory;

namespace MJ.Controllers
{
    public class WrathAndGloryController : Controller
    {
        CreatureService _creatureservice = new CreatureService();

        #region Système Gilead
        public ActionResult SystemGilead()
        {
            return View("~/Views/JDR/WrathAndGlory/SystemeGilead.cshtml");
        }
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

        #region Employeurs

        public ActionResult Akahir()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/Akahir.cshtml");
        }

        public ActionResult Vakuul()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/AxekraVakuul.cshtml");
        }
        public ActionResult Lorae()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/EshgarQuintusLorae.cshtml");
        }
        public ActionResult Varonius()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/JakelVaronius.cshtml");
        }
        public ActionResult GraceDEmysa()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/JeanneGraceDEmysa.cshtml");
        }
        public ActionResult Clade()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/MerramarClade.cshtml");
        }
        public ActionResult Mincara()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/OctaviaMincara.cshtml");
        }
        public ActionResult Fylamon()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/TaleriaFylamon.cshtml");
        }
        public ActionResult Dikaisune()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/TytronaDikaisune.cshtml");
        }
        public ActionResult Taranlys()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/LanrielTaranlys.cshtml");
        }
        public ActionResult PrincesseDEmeraude()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/LaPrincesseDEmeraude.cshtml");
        }
        public ActionResult Smasha()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/VazdrokSpikeySmasha.cshtml");
        }
        public ActionResult Maloquence()
        {
            return View("~/Views/JDR/WrathAndGlory/Employeurs/Maloquence.cshtml");
        }

        #endregion


        public ActionResult EmployeursListe()
        {
            return View("~/Views/JDR/WrathAndGlory/EmployeursList.cshtml");
        }

        public ActionResult Bestiaire()
        {
            List<Creature_WAG> listecreature = _creatureservice.GetListeCreature();

            listecreature = listecreature.OrderBy(c => c.Race).ToList();

            return View("~/Views/JDR/WrathAndGlory/Bestiaire.cshtml", listecreature);
        }

        public ActionResult AideMJ()
        {
            return View("~/Views/JDR/WrathAndGlory/AideMJ.cshtml");
        }

        [HttpPost]
        public ActionResult AfficherListeCreature(List<int> pIds)
        {   
            List<Creature_WAG> listeCreature = _creatureservice.GetListeCreature();

            List<Creature_WAG> listeCreatureSelected = listeCreature.Where(c => pIds.Contains(c.ID)).ToList();

            return PartialView("~/Views/JDR/WrathAndGlory/AffichageListeCreature.cshtml", listeCreatureSelected);
        }
    }
}