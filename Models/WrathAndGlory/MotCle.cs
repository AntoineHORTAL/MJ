using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class MotCle
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        public MotCle(int pId, string pNom, string pDescription)
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Description = pDescription;
        }
    }
}