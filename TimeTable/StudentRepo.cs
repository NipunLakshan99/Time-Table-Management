using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class StudentRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public StudentRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Student> GetAll()
        {
            var students = new List<Student>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Student;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Student_ID = (int)reader["Student_ID"],
                            Academic_Year_Semester = (string)reader["Academic_Year_Semester"],
                            Programme = (string)reader["Programme"],
                            Group_Number = (string)reader["Group_Number"],
                            Sub_Group_Number = (string)reader["Sub_Group_Number"]
                            /*Group_ID = (string)reader["Academic_Year_Semester"],
                            Sub_Group_ID = (string)reader["Academic_Year_Semester"]*/
                        });
                    }
                }
            }

            return students;

        }

        public void Add(Student student)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Student(Academic_Year_Semester,Programme,Group_Number,Sub_Group_Number,Group_ID,Sub_Group_ID) Values('{student.Academic_Year_Semester}','{student.Programme}','{student.Group_Number}','{student.Sub_Group_Number}','{student.Group_ID}','{student.Sub_Group_ID}');";
                command.ExecuteNonQuery();

            }



        }
        public void Update(Student student)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Student set Academic_Year_Semester = '{student.Academic_Year_Semester}', Programme = '{student.Programme}', Group_Number = '{student.Group_Number}', Sub_Group_Number = '{student.Sub_Group_Number}', Group_ID = '{student.Group_ID}', Sub_Group_ID = '{student.Sub_Group_ID}' where Student_ID = {student.Student_ID};";
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int Student_ID)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Student where Student_ID  = {Student_ID};";
                command.ExecuteNonQuery();

            }
        }

    }
}
