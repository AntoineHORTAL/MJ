using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class TraitArme
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }

        public TraitArme(int pId, string pNom, string pDescription) 
        { 
            this.Id = pId;
            this.Nom = pNom;
            this.Description = pDescription;
        }

        public TraitArme(int pId, string pNom, int pScore, string pDescription)
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Score = pScore;
            this.Description = pDescription;
        }

        public TraitArme(int pId, string pNom, string pCondition, string pDescription)
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Description = pDescription;
            this.Condition = pCondition;
        }

        public TraitArme(int pId, string pNom,int pScore, string pCondition, string pDescription)
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Score = pScore;
            this.Description = pDescription;
            this.Condition = pCondition;
        }
    }
}