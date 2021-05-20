using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LocationLecturerRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LocationLecturerRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<LocationLecturer> GetAll()
        {
            var LectureL = new List<LocationLecturer>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From LectureSession;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LectureL.Add(new LocationLecturer
                        {
                            ID = (int)reader["ID"],
                            Lecture_Name = (string)reader["Lecture_Name"],
                            Room_Name = (string)reader["Room_Name"]

                        });
                    }
                }

            }

            return LectureL;
        }

        public void Add(LocationLecturer locationLecturer)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into LectureSession(Lecture_Name,Room_Name) Values('{locationLecturer.Lecture_Name}','{locationLecturer.Room_Name}');";
                command.ExecuteNonQuery();
            }
        }
    }
}
    

