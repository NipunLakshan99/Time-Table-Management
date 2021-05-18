using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class SessionDayTimeRepo
    {

        DbProviderFactory factory;
        string provider;
        string connectionString;

        public SessionDayTimeRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        public List<SessionDayTime> GetAll()
        {
            var sessionDayTime = new List<SessionDayTime>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Sessions_Time;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sessionDayTime.Add(new SessionDayTime
                        {
                            ID = (int)reader["ID"],
                            Lecturer_1 = (string)reader["Lecturer_1"],
                            Lecturer_2 = (string)reader["Lecturer_2"],
                            Subject_Code = (string)reader["Subject_Code"],
                            Subject_Name = (string)reader["Subject_Name"],
                            Group_ID = (string)reader["Group_ID"],
                            Tag = (string)reader["Tag"],
                            Room = (string)reader["Room"],
                            Day = (string)reader["Day"],
                            Start_Time = (string)reader["Start_Time"],
                            End_Time = (string)reader["End_Time"]

                        });
                    }
                }

            }

            return sessionDayTime;
        }

        public void Add(SessionDayTime SessionDayTime)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Sessions_Time(Lecturer_1,Lecturer_2,Subject_Code,Subject_Name,Group_ID,Tag,Room,Day,Start_Time,End_Time) Values('{SessionDayTime.Lecturer_1}','{SessionDayTime.Lecturer_2}','{SessionDayTime.Subject_Code}','{SessionDayTime.Subject_Name}','{SessionDayTime.Group_ID}','{SessionDayTime.Tag}','{SessionDayTime.Room}','{SessionDayTime.Day}','{SessionDayTime.Start_Time}','{SessionDayTime.End_Time}');";
                command.ExecuteNonQuery();
            }
        }
    }
}

