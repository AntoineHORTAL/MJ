using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class Arme
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Catégorie { get; set; }
        public string DégâtsAvCalcul {  get; set; }
        public int DégâtsApCalcul { get; set; }
        public int DS { get; set; }
        public int PA { get; set; }
        public string Portée { get; set; }
        public string ListeTraits { get; set; }
        public List<TraitArme> Traits { get; set; }
        public int Valeur { get; set; }
        public string Rareté { get; set; }
        public string ListeMotClés { get; set; }
        public List<MotCle> MotsClés { get; set; }

        public Arme(int pId, string pNom, string pCatégorie, string pDégâtsAvCalcul, int pDS, int pPA, string pPortée, string pListeTraits, int pValeur, string pRareté, string pListeMotClés)
        {
            this.Id = pId;
            this.Nom = pNom;
            this.Catégorie = pCatégorie;
            this.DégâtsAvCalcul = pDégâtsAvCalcul;
            this.DS = pDS;
            this.PA = pPA;
            this.Portée = pPortée;
            this.ListeTraits = pListeTraits;
            this.Valeur = pValeur;
            this.Rareté = pRareté;
            this.ListeMotClés = pListeMotClés;
        }
    }
}