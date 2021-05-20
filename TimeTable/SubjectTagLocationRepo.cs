using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class SubjectTagLocationRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public SubjectTagLocationRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<SubjectTagLocation> GetAll()
        {
            var subTAGL = new List<SubjectTagLocation>();
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From SubjectTag;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subTAGL.Add(new SubjectTagLocation
                        {
                            ID = (int)reader["ID"],
                            Tag = (string)reader["Tag"],
                            Subject_Code = (string)reader["Subject_Code"],
                            Subject_Name = (string)reader["Subject_Name"],
                            Room_Name = (string)reader["Room_Name"],

                        });
                    }
                }

            }

            return subTAGL;
        }

        public void Add(SubjectTagLocation subjectTagLocation)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into SubjectTag(Tag,Subject_Code,Subject_Name,Room_Name) Values('{subjectTagLocation.Tag}','{subjectTagLocation.Subject_Code}','{subjectTagLocation.Subject_Name}','{subjectTagLocation.Room_Name}');";
                command.ExecuteNonQuery();
            }
        }
    }
}

