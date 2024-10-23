using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJ.Models;
using MJ.BLL;

namespace MJ.Controllers
{
    public class AvatarController : Controller
    {
        public ActionResult PersonnagePage()
        {
            return View("~/Views/JDR/Avatar/Personnage.cshtml");
        }

        public ActionResult CampagnePage()
        {
            return View("~/Views/JDR/Avatar/Campagne.cshtml");
        }

        public ActionResult AideMJPage()
        {
            return View("~/Views/JDR/Avatar/AideMJ.cshtml");
        }

        public List<PersonnageAvatar> GetAllPersonnage()
        {
            return new BLL_Avatar().GetAllPersonnages();
        }

        public ActionResult GetDetailPersonnage(int pIdPersonnage)
        {
            PersonnageAvatar personnage = new PersonnageAvatar();

            if(pIdPersonnage > 0)
            {
                personnage = new BLL_Avatar().GetPersonnageById(pIdPersonnage);
            }

            return PartialView("~/Views/JDR/Avatar/PersonnageDetail.cshtml", personnage);
        }

        public void  SavePersonnage(int pId, string pNom, int pMaitrise, int pCreativite, int pConcentration, int pHarmonie, int pEnthousiasme, int pFatigue, int pEtatConfus, int pEtatCoupable, int pEtatColere, int pEtatFragile, int pEtatTerrifie, int pEquilibre)
        {
            PersonnageAvatar personnage = new PersonnageAvatar();

            personnage.Concentration = pConcentration;
            personnage.Creativite = pCreativite;
            personnage.Enthousiasme = pEnthousiasme;
            personnage.Equilibre = pEquilibre;
            personnage.EtatColere = pEtatColere;
            personnage.EtatConfus = pEtatConfus;
            personnage.EtatCoupable = pEtatCoupable;
            personnage.EtatFragile = pEtatFragile;
            personnage.EtatTerrifie = pEtatTerrifie;
            personnage.Fatigue = pFatigue;
            personnage.Harmonie = pHarmonie;
            personnage.Id = pId;
            personnage.Maitrise = pMaitrise;
            personnage.Nom = pNom;

            new BLL_Avatar().InsertOrUpdatePersonnage(personnage);
        }
    }
}