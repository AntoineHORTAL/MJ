using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MJ.DAL;
using MJ.Models;

namespace MJ.BLL
{
    public class BLL_Avatar
    {

        public void InsertOrUpdatePersonnage(PersonnageAvatar pPersonnage)
        {
            new DAL_Avatar().InsertOrUpdatePersonnage(pPersonnage);
        }

        public List<PersonnageAvatar> GetAllPersonnages()
        {
            return new DAL_Avatar().GetAllPersonnage();
        }

        public PersonnageAvatar GetPersonnageById(int id)
        {
            return new DAL_Avatar().GetPersonnageById(id);
        }
    }
}