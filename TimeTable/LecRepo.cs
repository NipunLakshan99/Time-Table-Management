using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class LecRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public LecRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        //public List<Lecs> GetAll()
       // {
            //var lect = new List<Lecs>();
            //using (var connection = factory.CreateConnection())
            //{
               // connection.ConnectionString = connectionString;
                //connection.Open();
               // var command = factory.CreateCommand();
                //command.Connection = connection;
                //command.CommandText = "Select * From Lecs;";
                //using (DbDataReader reader = command.ExecuteReader())
                //{
                    //while (reader.Read())
                    //{
                        //lect.Add(new Lecs
                       // {
                            //Lecturer_ID = (int)reader["Lecturer_ID"],
                           // Lecturer_name = (string)reader["Lecturer_name"],
                           // Faculty = (string)reader["Faculty"],
                           // Department = (string)reader["Department"],
                           // Building = (string)reader["Building"],
                           // Level = (string)reader["Level"]
                        //});
                    //}
                //}
            //}

            //return lect;
        //}

        public void Add(Lecs lecturers)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Lecs(Lecturer_name,Faculty,Department,Building,Lvl,Rank) Values('{lecturers.Lecturer_name}','{lecturers.Faculty}','{lecturers.Department}','{lecturers.Building}','{lecturers.Level}','{lecturers.Rank}');";
                command.ExecuteNonQuery();
            }
        }

        public void Update(Lecs lecturers)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Lecs set Lecturer_name ='{lecturers.Lecturer_name}',Faculty ='{lecturers.Faculty}',Department ='{lecturers.Department}',Building ='{lecturers.Building}',Lvl ='{lecturers.Level}',Rank='{lecturers.Rank}' where Lecturer_ID = {lecturers.Lecturer_ID};";
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
                command.CommandText = $"Delete From Lecs where Lecturer_ID  = {Lecturer_ID};";
                command.ExecuteNonQuery();

            }
        }
    }
}
