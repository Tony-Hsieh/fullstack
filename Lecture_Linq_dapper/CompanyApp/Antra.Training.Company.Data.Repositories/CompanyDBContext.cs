using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
namespace Antra.Training.Company.Data.Repositories
{
    class CompanyDBContext
    {
        public string GetConnectionString()
        {

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            return builder.GetConnectionString("CompanyDB");
        }

        public int ExecuteDMLStatements(string cmd, Dictionary<string, object> parameters, CommandType ctype = CommandType.Text)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = cmd;
                sqlCommand.CommandType = ctype;
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                    }

                }
                sqlCommand.Connection = conn;
                int result = sqlCommand.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }
    }
}
