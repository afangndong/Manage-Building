using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseManageHome
{
    internal class ManageDAO
    {
        // version 1 only contains fake data. No connection to actual db
        string _connectionString = 
                "datasource=https://5aaa-2003-dc-b720-4416-854a-6fba-fe5b-3cd5.ngrok-free.app;port=443;username=root;password=admin;database=Locataire;";

        public List<Building> GetAllBuildings()
        {
            // start with an empty list
            List<Building> returnThese = new List<Building>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();

            //define the sql statement to fetch all Buildings
            MySqlCommand command = new MySqlCommand("SELECT * FROM Gebaude", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Building b = new Building
                    {
                        BuildingID = reader.GetInt32(0),
                        BuildingName = reader.GetString(1),
                        AdresseID = reader.GetInt32(2)
                    };
                    returnThese.Add(b);
                }

            }
            connection.Close();


            return returnThese;
        }
    }
}