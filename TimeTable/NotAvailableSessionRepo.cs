using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class NotAvailableSessionRepo
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;

        public NotAvailableSessionRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
            public List<NotAvailableSession> GetAll()
            {
                var NASession = new List<NotAvailableSession>();
                using (var connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    var command = factory.CreateCommand();
                    command.Connection = connection;
                    command.CommandText = "Select * From Not_Available_Session;";
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        NASession.Add(new NotAvailableSession
                        {
                                ID = (int)reader["ID"],
                                Session_ID = (string)reader["Session_ID"],
                                Day = (string)reader["Day"],
                                Start_Time = (string)reader["Start_Time"],
                                End_Time = (string)reader["End_Time"]
                                
                            });
                        }
                    }
                }
                return NASession;
            }

            public void Add(NotAvailableSession NotAvailableSession)
            {
                using (var connection = factory.CreateConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    var command = factory.CreateCommand();
                    command.Connection = connection;
                    command.CommandText = $"Insert into Not_Available_Session(Session_ID,Day,Start_Time,End_Time) Values('{NotAvailableSession.Session_ID}','{NotAvailableSession.Day}','{NotAvailableSession.Start_Time}','{NotAvailableSession.End_Time}');";
                    command.ExecuteNonQuery();
                }

            }
        }
 }

