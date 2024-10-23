using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MJ.BLL;
using MJ.Models;

namespace MJ.Controllers
{
    public class AlienController : Controller
    {
        public ActionResult ACDT()
        {
            return View("~/Views/JDR/Alien/Campagnes/AuCoeurDesTenebres.cshtml");
        }

        #region /\    Personnage    /\
        public ActionResult PersonnageDetail(int pId)
        {
            PersonnageAlien personnage = new BLL_Alien().GetPersonnageById(pId);

            return View("~/Views/JDR/Alien/PersonnageDetail.cshtml", personnage);
        }

        public ActionResult Personnage()
        {
            List<PersonnageAlien> listperso = new BLL_Alien().GetAllPersonnage();

            return View("~/Views/JDR/Alien/Personnage.cshtml", listperso);
        }

        public string SavePersonnage(int Id, string Nom, string Carriere, string Apparence, string Objectif_Personnel, string Camarade, string Rival, string Talent1, string Talent2, string Talent3, string Talent4, string Objet_Minuscule, string Objet_Fetche,
            string Equipement1, string Equipement2, string Equipement3, string Equipement4, string Equipement5, string Equipement6, string Equipement7, string Equipement8, string Equipement9, string Equipement10, string Blessure_Critique, string Protection,
            string Arme1, string Arme2, string Arme3, string Arme4, int Force, int Endurence, int Combat_Rapproche, int Machine_Lourde, int Esprit, int Observatiojn, int Survie, int Comtech, int Empathie, int Soins_Medicaux, int Manipulation, int Commandement,
            int Agilite, int Pilotage, int Mobilite, int Combat_a_Distance, int Niveau_Protection, int Encombrement, int Air, int Nourriture, int Energie, int Eau, int Bonus1, int Bonus2, int Bonus3, int Bonus4, int Degat1, int Degat2, int Degat3, int Degat4,
            string Portee1, string Portee2, string Portee3, string Portee4, int Stress, int Sante, int Radiation, int Experience, int Affame, int Deshydrate, int Epuise, int Gele, int Recit)
        {
            PersonnageAlien personnage = new PersonnageAlien(Id, Nom, Carriere, Apparence, Objectif_Personnel, Camarade, Rival, Talent1, Talent2, Talent3, Talent4, Objet_Minuscule, Objet_Fetche, Equipement1, Equipement2, Equipement3, Equipement4, Equipement5, 
                Equipement6, Equipement7, Equipement8, Equipement9, Equipement10, Blessure_Critique, Protection, Arme1, Arme2, Arme3, Arme4, Force, Endurence, Combat_Rapproche, Machine_Lourde, Esprit, Observatiojn, Survie, Comtech, Empathie, Soins_Medicaux, 
                Manipulation, Commandement, Agilite, Pilotage, Mobilite, Combat_a_Distance, Niveau_Protection, Encombrement, Air, Nourriture, Energie, Eau, Bonus1, Bonus2, Bonus3, Bonus4, Degat1, Degat2, Degat3, Degat4, Portee1, Portee2, Portee3, Portee4, Stress, 
                Sante, Radiation, Experience, Affame, Deshydrate, Epuise, Gele, Recit);

            return new BLL_Alien().InsertOrUpdatePersonnage(personnage);
        }

        public string DeletePersonnage(int Id)
        {
            return new BLL_Alien().DeletePersonnage(Id);
        }

        public ActionResult CreatePersonnage()
        {
            PersonnageAlien perso = new PersonnageAlien();

            return View("~/Views/JDR/Alien/PersonnageDetail.cshtml", perso);
        }
        #endregion

        #region /\    AideMJ    /\
        public ActionResult AideMJ()
        {
            List<Aide_MJ_Alien> listaidemj = new BLL_Alien().GetAllAideMJ();

            return View("~/VIews/JDR/Alien/AideMJ.cshtml", listaidemj);
        }

        public string EnregistrerAideMJ(int Id, string Titre, string Contenu)
        {
            Aide_MJ_Alien aidemj = new Aide_MJ_Alien(Id, Titre, Contenu);

            return new BLL_Alien().InsertOrUpdateAideMJ(aidemj);
        }

        public string DeleteAideMJ(int Id)
        {
            return new BLL_Alien().DeleteAideMJ(Id);
        }

        public string GetTitreContenuAIdeMJ(int Id)
        {
            Aide_MJ_Alien aidemj = new BLL_Alien().GetTitreContenuAIdeMJ(Id) ;

            return aidemj.Titre + "**" + aidemj.Contenu;
        }
        #endregion
    }
}