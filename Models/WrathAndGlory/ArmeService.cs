using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class ArmeService
    {
        public List<Arme> GetListeArme()
        {
            List<Arme> armes = new List<Arme>();

            armes.Add(new Arme(1, "Couteau", "Armes de mêlée", "F+2", 2, 0, "Lancer Fx4", "", 2, "Courant", "211,999"));
            armes.Add(new Arme(2, "Couteau de combat Astartes", "Armes de mêlée", "F+3", 2, -1, "", "8", 3, "Peu Courant", "211,4"));
            armes.Add(new Arme(3, "Épée", "Armes de mêlée", "F+3", 3, 0, "", "15", 3, "Courant", "211,999"));
            armes.Add(new Arme(4, "Couteau Monomoléculaire", "Armes de mêlée", "F+3", 2, -1, "", "16-1", 3, "Peu Courant", "211,23,41"));
            armes.Add(new Arme(5, "Matraque improvisée", "Armes de mêlée", "F+4", 2, 0, "", "2,6-1", 3, "Peu Courant", "999"));
            armes.Add(new Arme(6, "Baînette tronçonneuse", "Armes tronçonneuses", "F+4", 1, 0, "", "2", 3, "Rare", "222,23,16"));
            armes.Add(new Arme(7, "Épée tronçonneuse", "Armes tronçonneuses", "F+5", 4, 0, "", "2,15", 4, "Peu Courant", "222,8,23,16"));
            armes.Add(new Arme(8, "Eviscerator", "Armes tronçonneuses", "F+6", 6, -4, "2", "2,6-2", 6, "Rare", "222,201,4,7,2,204"));
            armes.Add(new Arme(9, "Hache tronçonneuse", "Armes tronçonneuses", "F+5", 6, 0, "", "2,16-1", 5, "Rare", "222,16"));
            armes.Add(new Arme(10, "Poing tronçonneuse", "Armes tronçonneuses", "F+7", 6, -4, "", "2,6-3", 10, "Très Rare", "222,204,23,16,4"));
            armes.Add(new Arme(11, "Élecrotfouet", "Armes de mêlée exotiques", "F+4", 2, 0, "4", "4,16-2", 4, "Très Rare", "207,999"));
            armes.Add(new Arme(12, "Fouet", "Armes de mêlée exotiques", "F+1", 1, 0, "4", "4", 2, "Courant", "219,999"));
            armes.Add(new Arme(13, "Fouet neural", "Armes de mêlée exotiques", "F+3", 2, -2, "4", "4", 5, "Rare", "207,2"));
            armes.Add(new Arme(14, "Matraque à décharge", "Armes de mêlée exotiques", "F+4", 4, -1, "1", "2,4", 5, "Peu Courant", "207,51"));
            armes.Add(new Arme(15, "Bâton de force", "Armes de force", "F+4", 2, -1, "2", "2-10", 2, "Rare", "209,301,201,24,4,5"));
            armes.Add(new Arme(16, "Épée de force", "Armes de force", "F+5", 4, -3, "", "10-15", 6, "Rare", "209,301,24,4"));
            //armes.Add(new Arme(0, "", "", 0, 0, "", "", 0, "", ""));

            return armes;
        }
    }
}