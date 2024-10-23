using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows;

namespace MJ.Models
{
    public class PersonnageAlien
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Carriere { get; set; }
        public string Apparence { get; set; }
        public string Objectif_Personnel { get; set; }
        public string Camarade { get; set; }
        public string Rival { get; set; }
        public string Talent1 { get; set; }
        public string Talent2 { get; set; }
        public string Talent3 { get; set; }
        public string Talent4 { get; set; } 
        public string Objet_Minuscule { get; set; }
        public string Objet_Fetiche { get; set; }
        public string Equipement1 { get; set; }
        public string Equipement2 { get;set; }
        public string Equipement3 { get;set; }
        public string Equipement4 { get;set; }  
        public string Equipement5 { get; set; }
        public string Equipement6 { get; set; }
        public string Equipement7 { get; set; }  
        public string Equipement8 { get; set; }
        public string Equipement9 { get; set; }
        public string Equipement10 { get; set; }
        public string Blessure_Critique { get; set; }
        public string Protection { get; set; }
        public string Arme1 { get; set; }
        public string Arme2 { get; set; }
        public string Arme3 { get; set; }
        public string Arme4 { get; set;}
        public int Force { get; set; }
        public int Endurence { get; set; }
        public int Combat_Rapproche { get; set; }
        public int Machine_Lourde { get; set; }
        public int Esprit {  get; set; }
        public int Observation { get; set; }
        public int Survie { get; set; }
        public int Comtech { get; set; }
        public int Empathie { get; set; }
        public int Soins_Medicaux { get; set; }
        public int Manipulation { get; set; }
        public int Commandement { get; set; }
        public int Agilite { get; set; }
        public int Pilotage { get; set; }
        public int Mobilite { get; set; }
        public int Combat_a_Distance { get; set; }
        public int Niveau_Protection { get; set; }
        public int Encombrement {  get; set; }
        public int Air { get; set; }
        public int Nourriture { get; set; }
        public int Energie { get; set; }
        public int Eau { get; set; }
        public int Bonus1 { get; set; }
        public int Bonus2 { get; set; }
        public int Bonus3 { get; set; }
        public int Bonus4 { get; set; }
        public int Degat1 { get; set; }
        public int Degat2 { get; set;}
        public int Degat3 { get; set;}
        public int Degat4 { get; set;}
        public string Portee1 { get; set; }
        public string Portee2 { get;set; }
        public string Portee3 { get;set; }
        public string Portee4 { get;set; }
        public int Stress {  get; set; }
        public int Sante {  get; set; }
        public int Radiation { get; set; }
        public int Experience { get; set; }
        public int Affame { get; set; }
        public int Deshydrate { get; set; }
        public int Epuise { get; set; }
        public int Gele {  get; set; }
        public int Recit { get; set; }


        public string ErrorMessage { get; set; }

        public PersonnageAlien()
        {
            Id = 01;
            Nom = "";
            Carriere = "";
            Apparence = "";
            Objectif_Personnel = "";
            Camarade = "";
            Rival = "";
            Talent1 = "";
            Talent2 = "";
            Talent3 = "";
            Talent4 = "";
            Objet_Minuscule = "";
            Objet_Fetiche = "";
            Equipement1 = "";
            Equipement2 = "";
            Equipement3 = "";
            Equipement4 = "";
            Equipement5 = "";
            Equipement6 = "";
            Equipement7 = "";
            Equipement8 = "";
            Equipement9 = "";
            Equipement10 = "";
            Blessure_Critique = "";
            Protection = "";
            Arme1 = "";
            Arme2 = "";
            Arme3 = "";
            Arme4 = "";
            Force = 0;
            Endurence = 0;
            Combat_Rapproche = 0;
            Machine_Lourde = 0;
            Esprit = 0;
            Observation = 0;
            Survie = 0;
            Comtech = 0;
            Empathie = 0;
            Soins_Medicaux = 0;
            Manipulation = 0;
            Commandement = 0;
            Agilite = 0;
            Pilotage = 0;
            Mobilite = 0;
            Combat_a_Distance = 0;
            Niveau_Protection = 0;
            Encombrement = 0;
            Air = 0;
            Nourriture = 0;
            Energie = 0;
            Eau = 0;
            Bonus1 = 0;
            Bonus2 = 0;
            Bonus3 = 0;
            Bonus4 = 0;
            Degat1 = 0;
            Degat2 = 0;
            Degat3 = 0;
            Degat4 = 0;
            Portee1 = "";
            Portee2 = "";
            Portee3 = "";
            Portee4 = "";
            Stress = 0;
            Sante = 0;
            Radiation = 0;
            Experience = 0;
            Affame = 0;
            Deshydrate = 0;
            Epuise = 0;
            Gele = 0;
            Recit = 0;
            ErrorMessage = "";
        }

        public PersonnageAlien(int id, string nom, string carriere, string apparence, string objectif_Personnel, string camarade, string rival, string talent1, string talent2, string talent3, string talent4, string objet_Minuscule, string objet_Fetiche, string equipement1, 
            string equipement2, string equipement3, string equipement4, string equipement5, string equipement6, string equipement7, string equipement8, string equipement9, string equipement10, string blessure_Critique, string protection, string arme1, string arme2, 
            string arme3, string arme4, int force, int endurence, int combat_Rapproche, int machine_Lourde, int esprit, int observation, int survie, int comtech, int empathie, int soins_Medicaux, int manipulation, int commandement, int agilite, int pilotage, 
            int mobilite, int combat_a_Distance, int niveau_Protection, int encombrement, int air, int nourriture, int energie, int eau, int bonus1, int bonus2, int bonus3, int bonus4, int degat1, int degat2, int degat3, int degat4, string portee1, string portee2, 
            string portee3, string portee4, int stress, int sante, int radiation, int experience, int affame, int deshydrate, int epuise, int gele, int recit)
        {
            Id = id;
            Nom = nom;
            Carriere = carriere;
            Apparence = apparence;
            Objectif_Personnel = objectif_Personnel;
            Camarade = camarade;
            Rival = rival;
            Talent1 = talent1;
            Talent2 = talent2;
            Talent3 = talent3;
            Talent4 = talent4;
            Objet_Minuscule = objet_Minuscule;
            Objet_Fetiche = objet_Fetiche;
            Equipement1 = equipement1;
            Equipement2 = equipement2;
            Equipement3 = equipement3;
            Equipement4 = equipement4;
            Equipement5 = equipement5;
            Equipement6 = equipement6;
            Equipement7 = equipement7;
            Equipement8 = equipement8;
            Equipement9 = equipement9;
            Equipement10 = equipement10;
            Blessure_Critique = blessure_Critique;
            Protection = protection;
            Arme1 = arme1;
            Arme2 = arme2;
            Arme3 = arme3;
            Arme4 = arme4;
            Force = force;
            Endurence = endurence;
            Combat_Rapproche = combat_Rapproche;
            Machine_Lourde = machine_Lourde;
            Esprit = esprit;
            Observation = observation;
            Survie = survie;
            Comtech = comtech;
            Empathie = empathie;
            Soins_Medicaux = soins_Medicaux;
            Manipulation = manipulation;
            Commandement = commandement;
            Agilite = agilite;
            Pilotage = pilotage;
            Mobilite = mobilite;
            Combat_a_Distance = combat_a_Distance;
            Niveau_Protection = niveau_Protection;
            Encombrement = encombrement;
            Air = air;
            Nourriture = nourriture;
            Energie = energie;
            Eau = eau;
            Bonus1 = bonus1;
            Bonus2 = bonus2;
            Bonus3 = bonus3;
            Bonus4 = bonus4;
            Degat1 = degat1;
            Degat2 = degat2;
            Degat3 = degat3;
            Degat4 = degat4;
            Portee1 = portee1;
            Portee2 = portee2;
            Portee3 = portee3;
            Portee4 = portee4;
            Stress = stress;
            Sante = sante;
            Radiation = radiation;
            Experience = experience;
            Affame = affame;
            Deshydrate = deshydrate;
            Epuise = epuise;
            Gele = gele;
            Recit = recit;
        }
    }
}