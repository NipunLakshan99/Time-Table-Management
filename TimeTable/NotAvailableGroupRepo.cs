using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class NotAvailableGroupRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public NotAvailableGroupRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        public List<NotAvailableGroup> GetAll()
        {
            var NAGroup = new List<NotAvailableGroup>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Not_Available_Group;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NAGroup.Add(new NotAvailableGroup
                        {
                            ID = (int)reader["ID"],
                            Main_Group = (string)reader["Main_Group"],
                            Sub_Group = (string)reader["Sub_Group"],
                            Day = (string)reader["Day"],
                            Start_Time = (string)reader["Start_Time"],
                            End_Time = (string)reader["End_Time"]

                        });
                    }
                }
            }
            return NAGroup;
        }

        public void Add(NotAvailableGroup NotAvailableGroup)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Not_Available_Group(Main_Group,Sub_Group,Day,Start_Time,End_Time) Values('{NotAvailableGroup.Main_Group}','{NotAvailableGroup.Sub_Group}','{NotAvailableGroup.Day}','{NotAvailableGroup.Start_Time}','{NotAvailableGroup.End_Time}');";
                command.ExecuteNonQuery();
            }

        }
    }
}
