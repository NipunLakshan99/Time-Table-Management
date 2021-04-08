using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class TagRepo
    {

        DbProviderFactory factory;
        string provider;
        string connectionString;

        public TagRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }

        public List<Tag> GetAll()
        {
            var tags = new List<Tag>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Tag;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tags.Add(new Tag
                        {
                            Tag_ID = (int)reader["Tag_ID"],
                            Tag_Name = (string)reader["Tag_Name"],
                            Tag_Code = (string)reader["Tag_Code"],
                            Related_Tag = (string)reader["Related_Tag"],
                           
                        });
                    }
                }
            }

            return tags;

        }

        public void Add(Tag tag)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Tag(Tag_Name,Tag_Code,Related_Tag) Values('{tag.Tag_Name}','{tag.Tag_Code}','{tag.Related_Tag}');";
                command.ExecuteNonQuery();

            }
                


        }
        public void Update(Tag tag)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update Tag set Tag_Name = '{tag.Tag_Name}', Tag_Code = '{tag.Tag_Code}', Related_Tag = '{tag.Related_Tag}' where Tag_ID = {tag.Tag_ID};";
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int Tag_ID)
        {

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Delete From Tag where Tag_ID  = {Tag_ID};";
                command.ExecuteNonQuery();

            }
        }


    }
}
