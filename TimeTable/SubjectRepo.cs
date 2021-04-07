using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class SubjectRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public SubjectRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Subject> GetAll()
        {
            var subjects = new List<Subject>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Subject;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Subject_ID = (int)reader["Subject_ID"],
                            Offerd_year = (string)reader["Offerd_year"],
                            Offerd_sem = (string)reader["Offerd_sem"],
                            Subject_name = (string)reader["Subject_name"],
                            Subject_Code = (string)reader["Subject_Code"],
                            No_Lec_hrs = (string)reader["No_Lec_hrs"],
                            No_Tute_hrs = (string)reader["No_Tute_hrs"],
                            No_Lab_hrs = (string)reader["No_Lab_hrs"],
                            No_Evaluation_hrs = (string)reader["No_Evaluation_hrs"]
                        });
                    }
                }
            }

            return subjects;
        }

        public void Add(Subject subject)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Subject(Offerd_year,Offerd_sem,Subject_name,Subject_Code,No_Lec_hrs,No_Tute_hrs,No_Lab_hrs,No_Evaluation_hrs) Values('{subject.Offerd_year}','{subject.Offerd_sem}','{subject.Subject_name}','{subject.Subject_Code}','{subject.No_Lec_hrs}','{subject.No_Tute_hrs}','{subject.No_Lab_hrs}','{subject.No_Evaluation_hrs}');";
                command.ExecuteNonQuery();
            }
        }

        public void Update(Subject subject)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Subject set Offerd_year ='{subject.Offerd_year}',Offerd_sem ='{subject.Offerd_sem}',Subject_name ='{subject.Subject_name}',Subject_Code ='{subject.Subject_Code}',No_Lec_hrs ='{subject.No_Lec_hrs}',No_Tute_hrs ='{subject.No_Tute_hrs}',No_Lab_hrs ='{subject.No_Lab_hrs}',No_Evaluation_hrs ='{subject.No_Evaluation_hrs};";
                command.ExecuteNonQuery();

            }

        }

        public void Delete(int Subject_ID)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Subject where Subject_ID  = {Subject_ID};";
                command.ExecuteNonQuery();

            }
        
        }

    }
}
