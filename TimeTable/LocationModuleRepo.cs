using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LocationModuleRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LocationModuleRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<LocationModule> GetAll()
        {
            var ModuleL = new List<LocationModule>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From LocationModule;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModuleL.Add(new LocationModule
                        {
                            ID = (int)reader["ID"],
                            Module_ID = (string)reader["Module_ID"],
                            Module_Name = (string)reader["Module_Name"],
                            Room_Name = (string)reader["Room_Name"]

                        });
                    }
                }

            }

            return ModuleL;
        }

        public void Add(LocationModule locationModule)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into LocationModule(Module_ID,Module_Name,Room_Name) Values('{locationModule.Module_ID}','{locationModule.Module_Name}','{locationModule.Room_Name}');";
                command.ExecuteNonQuery();
            }
        }
    }
}
    

