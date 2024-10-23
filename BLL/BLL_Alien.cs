using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Web;
using MJ.DAL;
using MJ.Models;

namespace MJ.BLL
{
    public class BLL_Alien
    {
        #region /\    Personngae     /\
        public PersonnageAlien GetPersonnageById(int pId)
        {
            return new DAL_Alien().GetPersonnageById(pId);
        }

        public List<PersonnageAlien> GetAllPersonnage()
        {
            return new DAL_Alien().GetAllPersonnage();
        }

        public string InsertOrUpdatePersonnage(PersonnageAlien personnage)
        {
            return new DAL_Alien().InsertOrUpdatePersonnage(personnage);
        }

        public string DeletePersonnage(int Id)
        {
            return new DAL_Alien().DeleteAideMJ(Id);
        }
        #endregion

        #region /\     AideMJ      /\
        public List<Aide_MJ_Alien> GetAllAideMJ()
        {
            return new DAL_Alien().GetAllAideMJ();
        }

        public string InsertOrUpdateAideMJ(Aide_MJ_Alien aidemj)
        {
            return new DAL_Alien().InsertOrUpdateAideMJ(aidemj);
        }

        public string DeleteAideMJ(int Id)
        {
            return new DAL_Alien().DeleteAideMJ(Id);
        }

        public Aide_MJ_Alien GetTitreContenuAIdeMJ(int Id)
        {
            return new DAL_Alien().GetTitreContenuAIdeMJ(Id);
        }
        #endregion
    }
}