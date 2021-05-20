using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LocationGroupRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LocationGroupRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<LocationGroup> GetAll()
        {
            var groupL = new List<LocationGroup>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From LocationGroup;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groupL.Add(new LocationGroup
                        {
                            ID = (int)reader["ID"],
                            Group_ID = (string)reader["Group_ID"],
                            Sub_Group_ID = (string)reader["Sub_Group_ID"],
                            Room_Name = (string)reader["Room_Name"],

                        });
                    }
                }

            }

            return groupL;
        }

        public void Add(LocationGroup locationGroup)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into LocationGroup(Group_ID,Sub_Group_ID,Room_Name) Values('{locationGroup.Group_ID}','{locationGroup.Sub_Group_ID}','{locationGroup.Room_Name}');";
                command.ExecuteNonQuery();
            }
        }
    }
}
   
