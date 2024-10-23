using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models
{
    public class Aide_MJ_Alien
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }


        public string ErrorMessage { get; set; }

        public Aide_MJ_Alien(int id, string titre, string contenu)
        {
            Id = id;
            Titre = titre;
            Contenu = contenu;
        }
        public Aide_MJ_Alien(string titre, string contenu)
        {
            Titre = titre.Trim();
            Contenu = contenu.Trim();
        }
        public Aide_MJ_Alien()
        {
            Id = 0;
            Titre = "";
            Contenu = "";
        }
    }
}