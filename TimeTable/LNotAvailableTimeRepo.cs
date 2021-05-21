using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LNotAvailableTimeRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LNotAvailableTimeRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<LNotAvailableTime> GetAll()
        {
            var lNotAvailableTimes = new List<LNotAvailableTime>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Location_Not_Available_Time;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lNotAvailableTimes.Add(new LNotAvailableTime
                        {
                            LNot_Available_Time_ID = (int)reader["LNot_Available_Time_ID"],
                            Room = (string)reader["Room"],
                            Day = (string)reader["Day"],
                            STime = (string)reader["STime"],
                            ETime = (string)reader["ETime"]
                        });
                    }
                }
            }
            return lNotAvailableTimes;
        }

        public void Add(LNotAvailableTime lNotAvailable)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Location_Not_Available_Time(Room,Day,STime,ETime) Values('{lNotAvailable.Room}','{lNotAvailable.Day}','{lNotAvailable.STime}','{lNotAvailable.ETime}');";
                command.ExecuteNonQuery();
            }
        }

        public void Update(LNotAvailableTime lNotAvailable)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Location_Not_Available_Time set Room ='{lNotAvailable.Room}',Day='{lNotAvailable.Day}',STime='{lNotAvailable.STime}',ETime='{lNotAvailable.ETime}';";
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int LNot_Available_Time_ID)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Location_Not_Available_Time where LNot_Available_Time_ID = {LNot_Available_Time_ID};";
                command.ExecuteNonQuery();
            }

        }
    }
}

