using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class Talent
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cout { get; set; }
        public string Prerequis {  get; set; }
        public string Effet { get; set; }

        public Talent(int pId, string pNom, string pCout, string pPrerequis, string pEffet)
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Cout = pCout;
            this.Prerequis = pPrerequis;
            this.Effet = pEffet;
        }
    }
}