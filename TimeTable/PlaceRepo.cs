using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class PlaceRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public PlaceRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Place> GetAll()
        {
            var places = new List<Place>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Location;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        places.Add(new Place
                        {
                            Location_ID = (int)reader["Location_ID"],
                            Building_name = (string)reader["Building_name"],
                            Room_name = (string)reader["Room_name"],
                            Room_type = (string)reader["Room_type"],
                            Capacity = (string)reader["Capacity"]
                        });
                    }
                }
            }
            return places;
        }

        public void Add(Place place)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Location(Building_name,Room_name,Room_type,Capacity) Values('{place.Building_name}','{place.Room_name}','{place.Room_type}','{place.Capacity}');";
                command.ExecuteNonQuery();

            }
        }

        public void Update(Place place)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Location set Building_name ='{place.Building_name}',Room_name ='{place.Room_name}',Room_type ='{place.Room_type}',Capacity ='{place.Capacity}'where Location_ID = {place.Location_ID};";
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int Location_ID)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Location where Location_ID = {Location_ID};";
                command.ExecuteNonQuery();
            }

        }

    }
}