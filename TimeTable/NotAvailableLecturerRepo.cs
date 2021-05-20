using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class NotAvailableLecturerRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public NotAvailableLecturerRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<NotAvailableLecturer> GetAll()
        {
            var NALecturer = new List<NotAvailableLecturer>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Not_Availabale_Lecturer;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NALecturer.Add(new NotAvailableLecturer
                        {
                            ID = (int)reader["ID"],
                            Lecturer_Name = (string)reader["Lecturer_Name"],
                            Day = (string)reader["Day"],
                            Start_Time = (string)reader["Start_Time"],
                            End_Time = (string)reader["End_Time"]

                        });
                    }
                }
            }
            return NALecturer;
        }

        public void Add(NotAvailableLecturer NotAvailableLecturer)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Not_Availabale_Lecturer(Lecturer_Name,Day,Start_Time,End_Time) Values('{NotAvailableLecturer.Lecturer_Name}','{NotAvailableLecturer.Day}','{NotAvailableLecturer.Start_Time}','{NotAvailableLecturer.End_Time}');";
                command.ExecuteNonQuery();
            }

        }
    }
}

