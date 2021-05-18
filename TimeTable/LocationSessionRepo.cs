using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LocationSessionRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LocationSessionRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<LocationSession> GetAll()
        {
            var sessionL = new List<LocationSession>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From SessionLocations;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sessionL.Add(new LocationSession
                        {
                            ID = (int)reader["ID"],
                            Lecturer_1 = (string)reader["Lecturer_1"],
                            Lecturer_2 = (string)reader["Lecturer_2"],
                            Subject_Code = (string)reader["Subject_Code"],
                            Subject_Name = (string)reader["Subject_Name"],
                            Group_ID = (string)reader["Group_ID"],
                            Tag = (string)reader["Tag"],
                            Room = (string)reader["Room"]


                        });
                    }
                }

            }

            return sessionL;
        }

       public void Add(LocationSession locationSession)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into SessionLocations(Lecturer_1,Lecturer_2,Subject_Code,Subject_Name,Group_ID,Tag,Room) Values('{locationSession.Lecturer_1}','{locationSession.Lecturer_2}','{locationSession.Subject_Code}','{locationSession.Subject_Name}','{locationSession.Group_ID}','{locationSession.Tag}','{locationSession.Room}');";
                command.ExecuteNonQuery();
            }
        }
    }
}
