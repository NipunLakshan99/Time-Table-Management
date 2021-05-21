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
            var Sessions = new List<Session>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Session;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sessions.Add(new Session
                        {
                            Session_ID = (int)reader["Session_ID"],
                            Lecture1 = (string)reader["Lecture1"],
                            Lecture2 = (string)reader["Lecture2"],
                            Group_ID = (string)reader["Group_ID"],
                            Subject_ID = (string)reader["Subject_ID"],
                            Subject_Name = (string)reader["Subject_Name"],
                            Tag = (string)reader["Tag"],
                            Noofstudent = (string)reader["Noofstudent"],
                            Duration = (string)reader["Duration"] 
                        });
                    }
                }
            }
            return Sessions;
        }

        public void Add(Session Session)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Session(Lecture1,Lecture2,Group_ID,Subject_ID,Subject_Name,Tag,Noofstudent,Duration) Values('{Session.Lecture1}','{Session.Lecture2}','{Session.Group_ID}','{Session.Subject_ID}','{Session.Subject_Name}','{Session.Tag}','{Session.Noofstudent}','{Session.Duration}');";
                command.ExecuteNonQuery();
            }
        }

        public void Update(Session Session)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Session set Lecture1 ='{Session.Lecture1}',Lecture2 ='{Session.Lecture2}',Group_ID ='{Session.Group_ID}',Subject_ID ='{Session.Subject_ID}',Subject_Name='{Session.Subject_Name}',Tag ='{Session.Tag}',Noofstudent ='{Session.Noofstudent}',Duration ='{Session.Duration}'where Session_ID = {Session.Session_ID};";
                command.ExecuteNonQuery();

            }

        }

        public void Delete(int Session_ID)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Session where Session_ID  = {Session_ID};";
                command.ExecuteNonQuery();

            }

        }


    }
}
