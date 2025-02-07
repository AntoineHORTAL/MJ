using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class Competence
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Description { get; set; }
        public int Reserve { get; set; }

        public Competence(int pId, string pNom, string pDescription, int pReserve) 
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Description = pDescription;
            this.Reserve = pReserve;
        }
        public Competence(int pId, string pNom, string pDescription) 
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Description = pDescription;
        }
    }
}