using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MJ.Models;

namespace MJ.DAL
{
    public class DAL_Avatar
    {
        protected string GetConnectionString()
        {
            SqlConnectionStringBuilder pConnctionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "(LocalDB)\\MSSQLLocalDB",
                InitialCatalog = "Avatar.mdf",
                AttachDBFilename = "F:\\PROJETS\\MJ\\App_Data\\Avatar.mdf",
                IntegratedSecurity = true
            };

            return pConnctionStringBuilder.ConnectionString;
        }

        internal void InsertOrUpdatePersonnage(PersonnageAvatar pPersonnage)
        {
            SqlConnection cnn;

            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "";

            if (pPersonnage.Id <= 0)
            {
                sql = $"INSERT INTO Personnage VALUES ('{pPersonnage.Nom}', {pPersonnage.Maitrise}, {pPersonnage.Creativite}, {pPersonnage.Concentration}, {pPersonnage.Harmonie}, {pPersonnage.Enthousiasme}, {pPersonnage.Fatigue}, {pPersonnage.EtatConfus}, {pPersonnage.EtatCoupable}, {pPersonnage.EtatColere}, {pPersonnage.EtatFragile}, {pPersonnage.EtatTerrifie}, {pPersonnage.Equilibre})";
            }
            else
            {
                sql = $"UPDATE Personnage SET Nom = '{pPersonnage.Nom}', Maitrise = {pPersonnage.Maitrise}, Creativite = {pPersonnage.Creativite}, Concentration = {pPersonnage.Concentration}, Harmonie = {pPersonnage.Harmonie}, Enthousiasme = {pPersonnage.Enthousiasme}, Fatigue = {pPersonnage.Fatigue}, EtatConfus = {pPersonnage.EtatConfus}, EtatCoupable = {pPersonnage.EtatCoupable}, EtatColere = {pPersonnage.EtatColere}, EtatFragile = {pPersonnage.EtatFragile}, EtatTerrifie = {pPersonnage.EtatTerrifie}, Equilibre = {pPersonnage.Equilibre} WHERE Id = {pPersonnage.Id}";
            }

            cnn = new SqlConnection(GetConnectionString());

            cnn.Open();

            adapter.InsertCommand = new SqlCommand(sql, cnn);

            adapter.InsertCommand.ExecuteNonQuery();

            adapter.Dispose();

            cnn.Close();
        }

        internal List<PersonnageAvatar> GetAllPersonnage()
        {
            SqlConnection cnn;

            SqlCommand command;

            SqlDataReader reader;

            string sql = "";

            List<PersonnageAvatar> listpersonnage = new List<PersonnageAvatar>();

            sql = "SELECT * FROM Personnage";

            cnn = new SqlConnection(GetConnectionString());

            cnn.Open();

            command = new SqlCommand(sql, cnn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                PersonnageAvatar personnage = CompletePersonnage(reader);

                listpersonnage.Add(personnage);
            }

            reader.Close();

            command.Dispose();

            cnn.Close();

            return listpersonnage;
        }

        protected PersonnageAvatar CompletePersonnage(SqlDataReader reader)
        {
            PersonnageAvatar personnage = new PersonnageAvatar();

            if (reader.GetValue(0) == DBNull.Value) personnage.Id = 0;
            else personnage.Id = (int)reader.GetValue(0);

            if (reader.GetValue(1) == DBNull.Value) personnage.Nom = "";
            else personnage.Nom = (string)reader.GetValue(1);

            if (reader.GetValue(2) == DBNull.Value) personnage.Maitrise = 0;
            else personnage.Maitrise = (int)reader.GetValue(2);

            if (reader.GetValue(3) == DBNull.Value) personnage.Creativite = 0;
            else personnage.Creativite = (int)reader.GetValue(3);

            if (reader.GetValue(4) == DBNull.Value) personnage.Concentration = 0;
            else personnage.Concentration = (int)reader.GetValue(4);

            if (reader.GetValue(5) == DBNull.Value) personnage.Harmonie = 0;
            else personnage.Harmonie = (int)reader.GetValue(5);

            if (reader.GetValue(6) == DBNull.Value) personnage.Enthousiasme = 0;
            else personnage.Enthousiasme = (int)reader.GetValue(6);

            if (reader.GetValue(7) == DBNull.Value) personnage.Fatigue = 0;
            else personnage.Fatigue = (int)reader.GetValue(7);

            if (reader.GetValue(8) == DBNull.Value) personnage.EtatConfus = 0;
            else personnage.EtatConfus = (int)reader.GetValue(8);

            if (reader.GetValue(9) == DBNull.Value) personnage.EtatCoupable = 0;
            else personnage.EtatCoupable = (int)reader.GetValue(9);

            if (reader.GetValue(10) == DBNull.Value) personnage.EtatColere = 0;
            else personnage.EtatColere = (int)reader.GetValue(10);

            if (reader.GetValue(11) == DBNull.Value) personnage.EtatFragile = 0;
            else personnage.EtatFragile = (int)reader.GetValue(11);

            if (reader.GetValue(12) == DBNull.Value) personnage.EtatTerrifie = 0;
            else personnage.EtatTerrifie = (int)reader.GetValue(12);

            if (reader.GetValue(13) == DBNull.Value) personnage.Equilibre = 0;
            else personnage.Equilibre = (int)reader.GetValue(13);

            return personnage;
        }

        internal PersonnageAvatar GetPersonnageById(int id)
        {
            PersonnageAvatar personnage = new PersonnageAvatar();

            SqlConnection cnn;

            SqlCommand command;

            SqlDataReader reader;

            string sql = "";

            sql = $"SELECT * FROM Personnage WHERE Id = {id}";

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

            return personnage;
        }
    }
}