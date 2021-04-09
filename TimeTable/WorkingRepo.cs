using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class WorkingRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public WorkingRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Working> GetAll()
        {
            var works = new List<Working>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Working;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        works.Add(new Working
                        {
                            Working_ID = (int)reader["Working_ID"],
                            No_worikng_days = (string)reader["No_worikng_days"],
                            Working_days = (string)reader["Working_days"],
                            Days = (string)reader["Days"],
                            Working_Time = (string)reader["Working_Time"],
                            Start_Time =(string)reader["Start_Time"],
                            End_Time =(string)reader["End_Time"],
                            Time_Slot =(string)reader["Time_Slot"]
                        }); 
                    }
                }
            }
            return works;
        }

        public void Add(Working working)
        {
                using (var connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    var command = factory.CreateCommand();
                    command.Connection = connection;
                    command.CommandText = $"Insert into Working(No_worikng_days,Working_days,Days,Working_Time,Start_Time,End_Time,Time_Slot) Values('{working.No_worikng_days}','{working.Working_days}','{working.Days}','{working.Working_Time}','{working.Start_Time}','{working.End_Time}','{working.Time_Slot}');";
                    command.ExecuteNonQuery();
                }

            }


        public void Update(Working working)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Working set No_worikng_days ='{working.No_worikng_days}',Working_days='{working.Working_days}',Days='{working.Days}',Working_Time='{working.Working_Time}',Start_Time='{working.Start_Time}',End_Time='{working.End_Time}',Time_Slot='{working.Time_Slot}' where Working_ID = {working.Working_ID};";
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int Working_ID)
        {
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Working where Working_ID = {Working_ID};";
                command.ExecuteNonQuery();
            }

        }
                
        }
    }
