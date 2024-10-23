using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Web;
using Azure.Identity;
using MJ.Models;

namespace MJ.DAL
{
    public class DAL_Alien
    {
        #region /\    Utilitaire     /\
        protected string GetConnectionString()
        {
            SqlConnectionStringBuilder pConnctionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "(LocalDB)\\MSSQLLocalDB",
                InitialCatalog = "Alien.mdf",
                AttachDBFilename = "F:\\PROJETS\\MJ\\App_Data\\Alien.mdf",
                IntegratedSecurity = true
            };

            return pConnctionStringBuilder.ConnectionString;
        }

        protected PersonnageAlien CompletePersonnage(SqlDataReader reader)
        {
            PersonnageAlien personnage = new PersonnageAlien();

            if (reader["Id"] == DBNull.Value) personnage.Id = 0;
                else personnage.Id = Convert.ToInt32(reader["Id"]);

            if (reader["Nom"] == DBNull.Value) personnage.Nom = "";
                else personnage.Nom = reader["Nom"].ToString();
            
            if (reader["Carriere"] == DBNull.Value) personnage.Carriere = "";
                else personnage.Carriere = reader["Carriere"].ToString();
            
            if (reader["Apparence"] == DBNull.Value) personnage.Apparence = "";
                else personnage.Apparence = reader["Apparence"].ToString();

            if (reader["Objectif_Personnel"] == DBNull.Value) personnage.Objectif_Personnel = "";
                else personnage.Objectif_Personnel = reader["Objectif_Personnel"].ToString();

            if (reader["Camarade"] == DBNull.Value) personnage.Camarade = "";
                else personnage.Camarade = reader["Camarade"].ToString();

            if (reader["Rival"] == DBNull.Value) personnage.Rival = "";
                else personnage.Rival = reader["Rival"].ToString();
            
            if (reader["Talent1"] == DBNull.Value) personnage.Talent1 = "";
                else personnage.Talent1 = reader["Talent1"].ToString();

            if (reader["Talent2"] == DBNull.Value) personnage.Talent2 = "";
                else personnage.Talent2 = reader["Talent2"].ToString();

            if (reader["Talent3"] == DBNull.Value) personnage.Talent3 = "";
                else personnage.Talent3 = reader["Talent3"].ToString();

            if (reader["Talent4"] == DBNull.Value) personnage.Talent4 = "";
                else personnage.Talent4 = reader["Talent4"].ToString();

            if (reader["Objet_Minuscule"] == DBNull.Value) personnage.Objet_Minuscule = "";
                else personnage.Objet_Minuscule = reader["Objet_Minuscule"].ToString();

            if (reader["Objet_Fetiche"] == DBNull.Value) personnage.Objet_Fetiche = "";
                else personnage.Objet_Fetiche = reader["Objet_Fetiche"].ToString();

            if (reader["Equipement1"] == DBNull.Value) personnage.Equipement1 = "";
                else personnage.Equipement1 = reader["Equipement1"].ToString();
            
            if (reader["Equipement2"] == DBNull.Value) personnage.Equipement2 = "";
                else personnage.Equipement2 = reader["Equipement2"].ToString();
            
            if (reader["Equipement3"] == DBNull.Value) personnage.Equipement3 = "";
                else personnage.Equipement3 = reader["Equipement3"].ToString();
            
            if (reader["Equipement4"] == DBNull.Value) personnage.Equipement4 = "";
                else personnage.Equipement4 = reader["Equipement4"].ToString();
            
            if (reader["Equipement5"] == DBNull.Value) personnage.Equipement5 = "";
                else personnage.Equipement5 = reader["Equipement5"].ToString();
            
            if (reader["Equipement6"] == DBNull.Value) personnage.Equipement6 = "";
                else personnage.Equipement6 = reader["Equipement6"].ToString();
            
            if (reader["Equipement7"] == DBNull.Value) personnage.Equipement7 = "";
                else personnage.Equipement7 = reader["Equipement7"].ToString();
            
            if (reader["Equipement8"] == DBNull.Value) personnage.Equipement8 = "";
                else personnage.Equipement8 = reader["Equipement8"].ToString();
            
            if (reader["Equipement9"] == DBNull.Value) personnage.Equipement9 = "";
                else personnage.Equipement9 = reader["Equipement9"].ToString();
            
            if (reader["Equipement10"] == DBNull.Value) personnage.Equipement10 = "";
                else personnage.Equipement10 = reader["Equipement10"].ToString();
            
            if (reader["Blessure_Critique"] == DBNull.Value) personnage.Blessure_Critique = "";
                else personnage.Blessure_Critique = reader["Blessure_Critique"].ToString();
            
            if (reader["Protection"] == DBNull.Value) personnage.Protection = "";
                else personnage.Protection = reader["Protection"].ToString();
            
            if (reader["Arme1"] == DBNull.Value) personnage.Arme1 = "";
                else personnage.Arme1 = reader["Arme1"].ToString();
            
            if (reader["Arme2"] == DBNull.Value) personnage.Arme2 = "";
                else personnage.Arme2 = reader["Arme2"].ToString();
            
            if (reader["Arme3"] == DBNull.Value) personnage.Arme3 = "";
                else personnage.Arme3 = reader["Arme3"].ToString();
            
            if (reader["Arme4"] == DBNull.Value) personnage.Arme4 = "";
                else personnage.Arme4 = reader["Arme4"].ToString();
            
            if (reader["Force"] == DBNull.Value) personnage.Force = 0;
                else personnage.Force = Convert.ToInt32(reader["Force"]);
            
            if (reader["Endurence"] == DBNull.Value) personnage.Endurence = 0;
                else personnage.Endurence = Convert.ToInt32(reader["Endurence"]);
            
            if (reader["Combat_Rapproche"] == DBNull.Value) personnage.Combat_Rapproche = 0;
                else personnage.Combat_Rapproche = Convert.ToInt32(reader["Combat_Rapproche"]);
            
            if (reader["Machine_Lourde"] == DBNull.Value) personnage.Machine_Lourde = 0;
                else personnage.Machine_Lourde = Convert.ToInt32(reader["Machine_Lourde"]);
            
            if (reader["Esprit"] == DBNull.Value) personnage.Esprit = 0;
                else personnage.Esprit = Convert.ToInt32(reader["Esprit"]);
            
            if (reader["Observation"] == DBNull.Value) personnage.Observation = 0;
                else personnage.Observation = Convert.ToInt32(reader["Observation"]);
            
            if (reader["Survie"] == DBNull.Value) personnage.Survie = 0;
                else personnage.Survie = Convert.ToInt32(reader["Survie"]);
            
            if (reader["Comtech"] == DBNull.Value) personnage.Comtech = 0;
                else personnage.Comtech = Convert.ToInt32(reader["Comtech"]);
            
            if (reader["Empathie"] == DBNull.Value) personnage.Empathie = 0;
                else personnage.Empathie = Convert.ToInt32(reader["Empathie"]);
            
            if (reader["Soins_Medicaux"] == DBNull.Value) personnage.Soins_Medicaux = 0;
                else personnage.Soins_Medicaux = Convert.ToInt32(reader["Soins_Medicaux"]);
            
            if (reader["Manipulation"] == DBNull.Value) personnage.Manipulation = 0;
                else personnage.Manipulation = Convert.ToInt32(reader["Manipulation"]);
            
            if (reader["Commandement"] == DBNull.Value) personnage.Commandement = 0;
                else personnage.Commandement = Convert.ToInt32(reader["Commandement"]);
            
            if (reader["Agilite"] == DBNull.Value) personnage.Agilite = 0;
                else personnage.Agilite = Convert.ToInt32(reader["Agilite"]);
            
            if (reader["Pilotage"] == DBNull.Value) personnage.Pilotage = 0;
                else personnage.Pilotage = Convert.ToInt32(reader["Pilotage"]);
            
            if (reader["Mobilite"] == DBNull.Value) personnage.Mobilite = 0;
                else personnage.Mobilite = Convert.ToInt32(reader["Mobilite"]);
            
            if (reader["Combat_a_Distance"] == DBNull.Value) personnage.Combat_a_Distance = 0;
                else personnage.Combat_a_Distance = Convert.ToInt32(reader["Combat_a_Distance"]);
            
            if (reader["Niveau_Protection"] == DBNull.Value) personnage.Niveau_Protection = 0;
                else personnage.Niveau_Protection = Convert.ToInt32(reader["Niveau_Protection"]);
            
            if (reader["Encombrement"] == DBNull.Value) personnage.Encombrement = 0;
                else personnage.Encombrement = Convert.ToInt32(reader["Encombrement"]);
            
            if (reader["Air"] == DBNull.Value) personnage.Air = 0;
                else personnage.Air = Convert.ToInt32(reader["Air"]);
            
            if (reader["Nourriture"] == DBNull.Value) personnage.Nourriture = 0;
                else personnage.Nourriture = Convert.ToInt32(reader["Nourriture"]);
            
            if (reader["Energie"] == DBNull.Value) personnage.Energie = 0;
                else personnage.Energie = Convert.ToInt32(reader["Energie"]);
            
            if (reader["Eau"] == DBNull.Value) personnage.Eau = 0;
                else personnage.Eau = Convert.ToInt32(reader["Eau"]);
            
            if (reader["Bonus1"] == DBNull.Value) personnage.Bonus1 = 0;
                else personnage.Bonus1 = Convert.ToInt32(reader["Bonus1"]);
            
            if (reader["Bonus2"] == DBNull.Value) personnage.Bonus2 = 0;
                else personnage.Bonus2 = Convert.ToInt32(reader["Bonus2"]);
            
            if (reader["Bonus3"] == DBNull.Value) personnage.Bonus3 = 0;
                else personnage.Bonus3 = Convert.ToInt32(reader["Bonus3"]);
            
            if (reader["Bonus4"] == DBNull.Value) personnage.Bonus4 = 0;
                else personnage.Bonus4 = Convert.ToInt32(reader["Bonus4"]);
            
            if (reader["Degat1"] == DBNull.Value) personnage.Degat1 = 0;
                else personnage.Degat1 = Convert.ToInt32(reader["Degat1"]);
            
            if (reader["Degat2"] == DBNull.Value) personnage.Degat2 = 0;
                else personnage.Degat2 = Convert.ToInt32(reader["Degat2"]);
            
            if (reader["Degat3"] == DBNull.Value) personnage.Degat3 = 0;
                else personnage.Degat3 = Convert.ToInt32(reader["Degat3"]);
            
            if (reader["Degat4"] == DBNull.Value) personnage.Degat4 = 0;
                else personnage.Degat4 = Convert.ToInt32(reader["Degat4"]);
            
            if (reader["Portee1"] == DBNull.Value) personnage.Portee1 = "";
                else personnage.Portee1 = reader["Portee1"].ToString();
            
            if (reader["Portee2"] == DBNull.Value) personnage.Portee2 = "";
                else personnage.Portee2 = reader["Portee2"].ToString();
            
            if (reader["Portee3"] == DBNull.Value) personnage.Portee3 = "";
                else personnage.Portee3 = reader["Portee3"].ToString();
            
            if (reader["Portee4"] == DBNull.Value) personnage.Portee4 = "";
                else personnage.Portee4 = reader["Portee4"].ToString();
            
            if (reader["Stress"] == DBNull.Value) personnage.Stress = 0;
                else personnage.Stress = Convert.ToInt32(reader["Stress"]);
            
            if (reader["Sante"] == DBNull.Value) personnage.Sante = 0;
                else personnage.Sante = Convert.ToInt32(reader["Sante"]);
            
            if (reader["Radiation"] == DBNull.Value) personnage.Radiation = 0;
                else personnage.Radiation = Convert.ToInt32(reader["Radiation"]);
            
            if (reader["Experience"] == DBNull.Value) personnage.Experience = 0;
                else personnage.Experience = Convert.ToInt32(reader["Experience"]);
            
            if (reader["Affame"] == DBNull.Value) personnage.Affame = 0;
                else personnage.Affame = Convert.ToInt32(reader["Affame"]);
            
            if (reader["Deshydrate"] == DBNull.Value) personnage.Deshydrate = 0;
                else personnage.Deshydrate = Convert.ToInt32(reader["Deshydrate"]);
            
            if (reader["Epuise"] == DBNull.Value) personnage.Epuise = 0;
                else personnage.Epuise = Convert.ToInt32(reader["Epuise"]);
            
            if (reader["Gele"] == DBNull.Value) personnage.Gele = 0;
                else personnage.Gele = Convert.ToInt32(reader["Gele"]);
            
            if (reader["Recit"] == DBNull.Value) personnage.Recit = 0;
                else personnage.Recit = Convert.ToInt32(reader["Recit"]);
            
            return personnage;
        }

        protected Aide_MJ_Alien CompleteAideMJ(SqlDataReader reader)
        {
            Aide_MJ_Alien aidemj = new Aide_MJ_Alien();

            if (reader["Id"] == DBNull.Value) aidemj.Id = 0;
            else aidemj.Id = Convert.ToInt32(reader["Id"]);

            if (reader["Titre"] == DBNull.Value) aidemj.Titre = "";
            else aidemj.Titre = reader["Titre"].ToString();

            if (reader["Contenu"] == DBNull.Value) aidemj.Contenu = "";
            else aidemj.Contenu = reader["Contenu"].ToString();

            return aidemj;
        }

        protected Aide_MJ_Alien PartialAideMJ(SqlDataReader reader)
        {
            Aide_MJ_Alien aidemj = new Aide_MJ_Alien();

            if (reader["Titre"] == DBNull.Value) aidemj.Titre = "";
            else aidemj.Titre = reader["Titre"].ToString().Trim();

            if (reader["Contenu"] == DBNull.Value) aidemj.Contenu = "";
            else aidemj.Contenu = reader["Contenu"].ToString().Trim();

            return aidemj;
        }
        #endregion

        #region /\    Personnage     /\
        internal PersonnageAlien GetPersonnageById(int pId)
        {
            PersonnageAlien personnage = new PersonnageAlien();

            SqlConnection cnn;

            SqlCommand command;

            SqlDataReader reader;

            string sql = "";

            sql = $"SELECT * FROM Personnage WHERE Id = {pId}";

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    personnage = CompletePersonnage(reader);
                }

                reader.Close();

                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                personnage.ErrorMessage = ex.Message;
            }

            return personnage;
        }

        internal List<PersonnageAlien> GetAllPersonnage()
        {
            List<PersonnageAlien> listperso = new List<PersonnageAlien>();

            SqlConnection cnn;

            SqlCommand command;

            SqlDataReader reader;

            string sql = "";

            sql = $"SELECT * FROM Personnage";

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listperso.Add(CompletePersonnage(reader));
                }

                reader.Close();

                command.Dispose();

                cnn.Close();
            }
            catch(Exception ex)
            {
                PersonnageAlien perso = new PersonnageAlien();
                
                perso.ErrorMessage = ex.Message;
                
                listperso.Add(perso);
            }

            return listperso;
        }

        internal string  InsertOrUpdatePersonnage(PersonnageAlien personnage)
        {
            string MessageRetour = "";

            SqlConnection cnn;

            SqlCommand command;

            string sql = "";

            sql = $"";

            if(personnage.Id > 0)
            {
                sql = $"UPDATE Personnage SET Nom = '{personnage.Nom}', Carriere = '{personnage.Carriere}', Apparence = '{personnage.Apparence}', Objectif_Personnel = '{personnage.Objectif_Personnel}', Camarade = '{personnage.Camarade}', Rival = '{personnage.Rival}'" +
                    $", Talent1 = '{personnage.Talent1}', Talent2 = '{personnage.Talent2}', Talent3 = '{personnage.Talent3}', Talent4 = '{personnage.Talent4}', Objet_Minuscule = '{personnage.Objet_Minuscule}', Objet_Fetiche = '{personnage.Objet_Fetiche}'" +
                    $", Equipement1 = '{personnage.Equipement1}', Equipement2= '{personnage.Equipement2}', Equipement3 = '{personnage.Equipement3}', Equipement4 = '{personnage.Equipement4}', Equipement5 = '{personnage.Equipement5}', Equipement6 = '{personnage.Equipement6}'" +
                    $", Equipement7 = '{personnage.Equipement7}', Equipement8 = '{personnage.Equipement8}', Equipement9 = '{personnage.Equipement9}', Equipement10 = '{personnage.Equipement10}', Blessure_Critique = '{personnage.Blessure_Critique}'" +
                    $", Protection = '{personnage.Protection}', Arme1 = '{personnage.Arme1}', Arme2 = '{personnage.Arme2}', Arme3 = '{personnage.Arme3}', Arme4 = '{personnage.Arme4}', Force = '{personnage.Force}', Endurence = '{personnage.Endurence}'" +
                    $", Combat_Rapproche = '{personnage.Combat_Rapproche}', Machine_Lourde = '{personnage.Machine_Lourde}', Esprit = '{personnage.Esprit}', Observation = '{personnage.Observation}', Survie = '{personnage.Survie}', Comtech = '{personnage.Comtech}'" +
                    $", Empathie = '{personnage.Empathie}', Soins_Medicaux = '{personnage.Soins_Medicaux}', Manipulation = '{personnage.Manipulation}', Commandement = '{personnage.Commandement}', Agilite = '{personnage.Agilite}', Pilotage = '{personnage.Pilotage}'" +
                    $", Mobilite = '{personnage.Mobilite}', Combat_a_Distance = '{personnage.Combat_a_Distance}', Niveau_Protection = '{personnage.Niveau_Protection}', Encombrement = {personnage.Encombrement}, Air = {personnage.Air}, Nourriture = {personnage.Nourriture}" +
                    $", Energie = {personnage.Energie}, Eau = {personnage.Eau}, Bonus1 = {personnage.Bonus1}, Bonus2 = {personnage.Bonus2}, Bonus3 = {personnage.Bonus3}, Bonus4 = {personnage.Bonus4}, Degat1 = {personnage.Degat1}, Degat2 = {personnage.Degat2}" +
                    $", Degat3 = {personnage.Degat3}, Degat4 = {personnage.Degat4}, Portee1 = {personnage.Portee1}, Portee2 = {personnage.Portee2}, Portee3 = {personnage.Portee3}, Portee4 = {personnage.Portee4}, Stress = {personnage.Stress}, Sante = {personnage.Sante}" +
                    $", Radiation = {personnage.Radiation}, Experience = {personnage.Experience}, Affame = {personnage.Affame}, Deshydrate = {personnage.Deshydrate}, Epuise = {personnage.Epuise}, Gele = {personnage.Gele}, Recit = {personnage.Recit}" +
                    $" WHERE Id = {personnage.Id}";
            }
            else
            {
                sql = $"INSERT INTO Personnage VALUES('{personnage.Nom}', '{personnage.Carriere}', '{personnage.Apparence}', '{personnage.Objectif_Personnel}', '{personnage.Camarade}', '{personnage.Rival}', '{personnage.Talent1}', '{personnage.Talent2}', '{personnage.Talent3}'" +
                    $", '{personnage.Talent4}', '{personnage.Objet_Minuscule}', '{personnage.Objet_Fetiche}', '{personnage.Equipement1}', '{personnage.Equipement2}', '{personnage.Equipement3}', '{personnage.Equipement4}', '{personnage.Equipement5}', '{personnage.Equipement6}'" +
                    $", '{personnage.Equipement7}', '{personnage.Equipement8}', '{personnage.Equipement9}', '{personnage.Equipement10}', '{personnage.Blessure_Critique}', '{personnage.Protection}', '{personnage.Arme1}', '{personnage.Arme2}', '{personnage.Arme3}'" +
                    $", '{personnage.Arme4}', {personnage.Force}, {personnage.Endurence}, {personnage.Combat_Rapproche}, {personnage.Machine_Lourde}, {personnage.Esprit}, {personnage.Observation}, {personnage.Survie}, {personnage.Comtech}, {personnage.Empathie}" +
                    $", {personnage.Soins_Medicaux}, {personnage.Manipulation}, {personnage.Commandement}, {personnage.Agilite}, {personnage.Pilotage}, {personnage.Mobilite}, {personnage.Combat_a_Distance}, {personnage.Niveau_Protection}, {personnage.Encombrement}" +
                    $", {personnage.Air}, {personnage.Nourriture}, {personnage.Energie}, {personnage.Eau}, {personnage.Bonus1}, {personnage.Bonus2}, {personnage.Bonus3}, {personnage.Bonus4}, {personnage.Degat1}, {personnage.Degat2}, {personnage.Degat3}, {personnage.Degat4}" +
                    $", '{personnage.Portee1}', '{personnage.Portee2}', '{personnage.Portee3}', '{personnage.Portee4}', {personnage.Stress}, {personnage.Sante}, {personnage.Radiation}, {personnage.Experience}, {personnage.Affame}, {personnage.Deshydrate}, {personnage.Epuise}" +
                    $", {personnage.Gele}, {personnage.Recit})";
            }

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                command.ExecuteNonQuery();

                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageRetour = ex.Message;
            }

            return MessageRetour;
        }

        internal string DeletePersonnage(int Id)
        {
            string MessageRetour = "";

            SqlConnection cnn;

            SqlCommand command;

            string sql = $"DELETE FROM Personnage WHERE Id = {Id}";

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                command.ExecuteNonQuery();

                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageRetour = ex.Message;
            }

            return MessageRetour;
        }
        #endregion

        #region /\    AideMJ     /\
        internal List<Aide_MJ_Alien> GetAllAideMJ()
        {
            List<Aide_MJ_Alien> listaidemj = new List<Aide_MJ_Alien>();

            SqlConnection cnn;

            SqlCommand command;

            SqlDataReader reader;

            string sql = $"SELECT * FROM AideMJ";

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaidemj.Add(CompleteAideMJ(reader));
                }

                reader.Close();

                command.Dispose();

                cnn.Close();
            }
            catch (SqlException ex)
            {
                Aide_MJ_Alien aidemj = new Aide_MJ_Alien();

                aidemj.ErrorMessage = ex.Message;

                listaidemj.Add(aidemj);
            }

            return listaidemj;
        }

        internal string InsertOrUpdateAideMJ(Aide_MJ_Alien aidemj)
        {
            string MessageRetour = "";

            SqlConnection cnn;

            SqlCommand command;

            string sql = $"";

            if (aidemj.Id > 0)
            {
                sql = $"UPDATE AideMJ SET Titre = '{aidemj.Titre}', Contenu = '{aidemj.Contenu}' WHERE Id = {aidemj.Id}";
            }
            else
            {
                sql = $"INSERT INTO AideMJ (Titre, Contenu) VALUES('{aidemj.Titre}', '{aidemj.Contenu}')";
            }

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                command.ExecuteNonQuery();

                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageRetour = ex.Message;
            }

            return MessageRetour;
        }

        internal string DeleteAideMJ(int Id)
        {
            string MessageRetour = "";

            SqlConnection cnn;

            SqlCommand command;

            string sql = $"DELETE FROM AideMJ WHERE Id = {Id}";

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                command.ExecuteNonQuery();

                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageRetour = ex.Message;
            }

            return MessageRetour;
        }

        internal Aide_MJ_Alien GetTitreContenuAIdeMJ(int Id)
        {
            Aide_MJ_Alien aidemj = new Aide_MJ_Alien();

            SqlConnection cnn;

            SqlCommand command;

            SqlDataReader reader;

            string sql = $"SELECT * FROM AideMJ WHERE Id = {Id}";

            try
            {
                cnn = new SqlConnection(GetConnectionString());

                cnn.Open();

                command = new SqlCommand(sql, cnn);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    aidemj = PartialAideMJ(reader);
                }

                reader.Close();

                command.Dispose();

                cnn.Close();
            }
            catch ( Exception ex )
            {
                aidemj.ErrorMessage = ex.Message;
            }

            return aidemj;
        }
        #endregion
    }
}