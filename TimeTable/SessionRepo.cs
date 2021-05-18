using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class SessionRepo
    {

        DbProviderFactory factory;
        string provider;
        string connectionString;

        public SessionRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Session> GetAll()
        {
            var session = new List<Session>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Sessions;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        session.Add(new Session
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

            return session;
        }

        public void Add(Session Session)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Sessions(Lecturer_1,Lecturer_2,Subject_Code,Subject_Name,Group_ID,Tag,Room) Values('{Session.Lecturer_1}','{Session.Lecturer_2}','{Session.Subject_Code}','{Session.Subject_Name}','{Session.Group_ID}','{Session.Tag}','{Session.Room}');";
                command.ExecuteNonQuery();
            }
        }
    }
}
