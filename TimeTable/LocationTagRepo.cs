using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LocationTagRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LocationTagRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<LocationTag> GetAll()
        {
            var tagL = new List<LocationTag>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Tag;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tagL.Add(new LocationTag
                        {
                            ID = (int)reader["ID"],
                            Tag = (string)reader["Tag"],
                            Subject_Name = (string)reader["Subject_Name"],
                            Room_Name = (string)reader["Room_Name"]

                        });
                    }
                }

            }

            return tagL;
        }

        public void Add(LocationTag locationTag)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Tag(Tag,Subject_Name,Room_Name) Values('{locationTag.Tag}','{locationTag.Subject_Name}','{locationTag.Room_Name}');";
                command.ExecuteNonQuery();
            }
        }
    }
}
