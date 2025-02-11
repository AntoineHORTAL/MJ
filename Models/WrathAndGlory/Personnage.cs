using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class Personnage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Tier { get; set; }
        public int Rang { get; set; }
        public string Espèce { get; set; }
        public string Archétype { get; set; } // faire objet Archétype
        public string Faction { get; set; }
        public List<MotCle> MotsClés {  get; set; }
        public string Historique { get; set; }
        public int Force { get; set; }
        public int Endurance { get; set; }
        public int Agilité { get; set; }
        public int Initiative { get; set; }
        public int ForceMentale { get; set; }
        public int Intelligence { get; set; }
        public int Sociabilité { get; set; }
        public int Athlétisqme { get; set; }
    }
}