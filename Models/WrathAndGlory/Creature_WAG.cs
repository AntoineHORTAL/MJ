using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class Creature_WAG
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string CheminImage { get; set; }
        public char MenaceT1 { get; set; }
        public char MenaceT2 { get; set; }
        public char MenaceT3 { get; set; }
        public char MenaceT4 { get; set; }
        public int Force { get; set; }
        public int Endurance { get; set; }
        public int Agilite { get; set; }
        public int Initiative { get; set; }
        public int ForceMentale { get; set; }
        public int Intelligence { get; set; }
        public int Sociabilite { get; set; }
        public int Vitesse { get; set; }
        public string Race { get; set; }
        public List<MotCle> MotsCle { get; set; }
        public string ListeMotCle { get; set; }
        public string Resistance { get; set; }
        public int Defense { get; set; }
        public int Blessures { get; set; }
        public int Stress { get; set; }
        public List<Competence> ListeCompetences { get; set; }
        public string Bonus { get; set; }
        public List<Aptitude> Aptitudes { get; set; }
        public int Conviction { get; set; }
        public int Resolution { get; set; }
        public char Taille { get; set; }

        public Creature_WAG(int ID, string Nom, string CheminImage, char MenaceT1, char MenaceT2, char MenaceT3, char MenaceT4, int Force, int Endurence, int Agilite, int Initiative, int ForceMentale, int Intelligence, int Sociabilite, string Race, string ListeMotCle)
        {
            this.ID = ID;
            this.Nom = Nom;
            this.CheminImage = CheminImage;
            this.MenaceT1 = MenaceT1;
            this.MenaceT2 = MenaceT2;
            this.MenaceT3 = MenaceT3;
            this.MenaceT4 = MenaceT4;
            this.Force = Force;
            this.Endurance = Endurence; 
            this.Agilite = Agilite;
            this.Initiative = Initiative;
            this.ForceMentale = ForceMentale;
            this.Intelligence = Intelligence;
            this.Sociabilite = Sociabilite;
            this.Race = Race;
            this.ListeMotCle = ListeMotCle;
        }
    }

}