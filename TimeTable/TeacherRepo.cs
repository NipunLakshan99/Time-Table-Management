using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class TeacherRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public TeacherRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Teacher>GetAll()
        {
            var teachers = new List<Teacher>();
            using(var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Teacher;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        teachers.Add(new Teacher
                        {
                            Lecturer_ID = (int)reader["Lecturer_ID"],
                            Lecturer_name = (string)reader["Lecturer_name"],
                            Faculty = (string)reader["Faculty"],
                            Department = (string)reader["Department"],
                            Building = (string)reader["Building"]
                            //Level = (string)reader["Level"]
                        });
                    }
                }

            }

            return teachers;
        }

        public void Add(Teacher teacher)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Teacher(Lecturer_name,Faculty,Department,Building,Lvl,Rank) Values('{teacher.Lecturer_name}','{teacher.Faculty}','{teacher.Department}','{teacher.Building}','{teacher.Level}','{teacher.Rank}');";
                command.ExecuteNonQuery();
            }
        }
        public void Update(Teacher teacher)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Teacher set Lecturer_name ='{teacher.Lecturer_name}',Faculty ='{teacher.Faculty}',Department ='{teacher.Department}',Building ='{teacher.Building}',Lvl ='{teacher.Level}',Rank='{teacher.Rank}' where Lecturer_ID = {teacher.Lecturer_ID};";
                command.ExecuteNonQuery();

            }
        }
        public void Delete(int Lecturer_ID)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Teacher where Lecturer_ID  = {Lecturer_ID};";
                command.ExecuteNonQuery();

            }
        }


    }
}
