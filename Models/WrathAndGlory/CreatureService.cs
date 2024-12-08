using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class CreatureService
    {
        public List<Creature__WAG> GetListeCreature()
        {
            List<Creature__WAG> listcreature = new List<Creature__WAG>();

            listcreature.Add(new Creature__WAG(1, "Cultiste", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Chaos/Cultiste.jpg", 'T', 'T', 'T', 'T', 2, 3, 2, 3, 3, 2, 3, "Chaos"));
            listcreature.Add(new Creature__WAG(3, "Horreur Rose", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Chaos/HorreurRose.jpg", 'A', 'A', 'E', 'E', 3, 3, 3, 4, 4, 4, 4, "Chaos"));
            listcreature.Add(new Creature__WAG(8, "Overlord", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Necron/Overlord.jpg", 'A', 'A', 'A', 'A', 8, 8, 5, 5, 10, 8, 4, "Necron"));
            listcreature.Add(new Creature__WAG(7, "Bizarboy", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Ork/Bizarboy.jpg", 'A', 'E', 'E', 'T', 6, 6, 2, 3, 5, 1, 1, "Ork"));
            listcreature.Add(new Creature__WAG(2, "Psyker Renegat", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Chaos/PsykerRenegat.jpg", 'A', 'E', 'E', 'T', 2, 3, 2, 5, 5, 4, 2, "Chaos"));
            listcreature.Add(new Creature__WAG(5, "Boy", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Ork/Boy.jpg", 'E', 'T', 'T', 'T', 4, 4, 2, 3, 1, 1, 1, "Ork"));
            listcreature.Add(new Creature__WAG(6, "Warboss", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Ork/Warboss.jpg", 'A', 'A', 'A', 'A', 12, 8, 3, 5, 6, 2, 3, "Ork"));
            listcreature.Add(new Creature__WAG(4, "Sanguinaire", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Chaos/Sanguinaire.jpg", 'A', 'A', 'E', 'E', 7, 6, 3, 4, 3, 3, 3, "Chaos"));
            listcreature.Add(new Creature__WAG(9, "Soldat Necron", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Necron/SoldatNecron.jpg", 'E', 'E', 'T', 'T', 4, 4, 2, 2, 3, 2, 1, "Necron"));
            listcreature.Add(new Creature__WAG(10, "Avatar de Khaine", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/AvatarOfKhaine.jpg", 'A', 'A', 'A', 'A', 11, 13, 5, 6, 8, 4, 1, "Aeldari"));
            listcreature.Add(new Creature__WAG(11, "Ranger", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/Ranger.jpg", 'A', 'E', 'T', 'T', 3, 3, 6, 4, 3, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(12, "Fire Dragon", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/FireDragon.jpg", 'A', 'E', 'E', 'T', 3, 4, 5, 5, 4, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(13, "Swooping Hawk", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/SwoopingHawk.jpg", 'A', 'E', 'E', 'T', 3, 3, 5, 5, 4, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(14, "Archon", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Drukhari/Archon.jpg", 'A', 'A', 'A', 'A', 4, 4, 6, 6, 7, 7, 5, "Drukhari"));
            listcreature.Add(new Creature__WAG(15, "XV95 Ghostkeel Battlesuit Shas'vre", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Tau/XV95GhostkeelBattlesuitShas'vre.jpg", 'A', 'A', 'A', 'A', 8, 10, 9, 9, 7, 5, 4, "Tau"));
            listcreature.Add(new Creature__WAG(16, "XV25 Stealth Battlesuit Sahs'ui", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Tau/XV25StealthBattlesuitShas'ui.jpg", 'A', 'A', 'E', 'T', 5, 5, 6, 6, 3, 4, 3, "Tau"));
            listcreature.Add(new Creature__WAG(17, "XV8 Crisis Battlesuit", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Tau/XV8CrisisBattlesuit.jpg", 'A', 'A', 'E', 'E', 7, 7, 8, 8, 5, 3, 4, "Tau"));
            listcreature.Add(new Creature__WAG(18, "Wych", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Drukhari/Wych.jpg", 'E', 'T', 'T', 'T', 3, 3, 3, 5, 3, 2, 1, "Drukhari"));
            listcreature.Add(new Creature__WAG(19, "Wraithlord", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/Wraithlord.jpg", 'A', 'A', 'E', 'T', 12, 13, 3, 4, 6, 4, 1, "Aeldari"));
            listcreature.Add(new Creature__WAG(20, "Wraithguard", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/Wraithguard.jpg", 'A', 'A', 'E', 'T', 7, 9, 4, 4, 5, 3, 1, "Aeldari"));
            listcreature.Add(new Creature__WAG(21, "Wraithblade", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/Wraithblade.jpg", 'A', 'A', 'E', 'T', 8, 9, 3, 4, 5, 3, 1, "Aeldari"));
            listcreature.Add(new Creature__WAG(22, "Wrack", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Drukhari/Wrack.jpg", 'E', 'T', 'T', 'T', 3, 5, 3, 3, 3, 2, 1, "Drukhari"));
            listcreature.Add(new Creature__WAG(23, "Way Seeker", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/WaySeeker.jpg", 'A', 'E', 'T', 'T', 3, 3, 4, 5, 7, 4, 3, "Aeldari"));
            listcreature.Add(new Creature__WAG(24, "Warp Spider", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/WarpSpider.jpg", 'A', 'E', 'E', 'T', 3, 3, 5, 5, 4, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(25, "Warlock", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/Warlock.jpg", 'A', 'A', 'E', 'E', 3, 3, 5, 5, 7, 5, 3, "Aeldari"));
            listcreature.Add(new Creature__WAG(26, "Void Reaver", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/VoidReaver.jpg", 'A', 'E', 'T', 'T', 3, 3, 4, 4, 2, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(27, "Vespid Strain Leader", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Tau/VespidStrainLeader.jpg", 'E', 'T', 'T', 'T', 5, 6, 5, 3, 4, 3, 1, "Tau"));
            listcreature.Add(new Creature__WAG(28, "Vespid Stingwing", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Tau/VespidStingwing.jpg", 'T', 'T', 'T', 'T', 5, 5, 5, 3, 2, 2, 1, "Aeldari"));
            listcreature.Add(new Creature__WAG(29, "Veroleux", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Chaos/Veroleux.jpg", 'T', 'T', 'T', 'T', 4, 3, 2, 2, 1, 1, 1, "Chaos"));
            listcreature.Add(new Creature__WAG(30, "Triarch Praetorian", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Necron/TriarchPraetorian.jpg", 'A', 'A', 'E', 'E', 6, 7, 4, 5, 6, 4, 3, "Necron"));
            listcreature.Add(new Creature__WAG(31, "Technomancer", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Necron/Technomancer.jpg", 'A', 'A', 'E', 'E', 4, 5, 4, 4, 6, 8, 3, "Necron"));
            listcreature.Add(new Creature__WAG(32, "Tankbusta", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Ork/Tankbusta.jpg", 'A', 'E', 'T', 'T', 5, 6, 2, 3, 2, 2, 1, "Ork"));
            listcreature.Add(new Creature__WAG(33, "Talos", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Drukhari/Talos.jpg", 'A', 'A', 'E', 'E', 10, 10, 2, 4, 6, 2, 1, "Drulhari"));
            listcreature.Add(new Creature__WAG(35, "Succubus", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Drukhari/Succubus.jpg", 'A', 'A', 'A', 'A', 4, 4, 6, 7, 7, 6, 5, "Drukhari"));
            listcreature.Add(new Creature__WAG(36, "Striking Scorpion", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/StrikingScorpion.jpg", 'A', 'E', 'T', 'T', 4, 3, 5, 5, 4, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(37, "Storm Guardian", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Aeldari/StormGuardian.jpg", 'E', 'T', 'T', 'T', 3, 3, 4, 4, 3, 3, 2, "Aeldari"));
            listcreature.Add(new Creature__WAG(38, "Stormboy", "https://localhost:44385/Images/WrathAndGLory/Bestiaire/Ork/Stormboy.jpg", 'E', 'E', 'T', 'T', 4, 6, 3, 3, 2, 1, 3, "Ork"));
            //listcreature.Add(new Creature__WAG(, "", "https://localhost:44385/Images/WrathAndGLory/Bestiaire//.jpg", '', '', '', '', , , , , , , , ""));

            return listcreature;
        }
    }
}