using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Antra.Dapper.Data.Repository
{
    class CompanyDBContext
    {
        public IDbConnection GetConnection()
        {
            var configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string conn = configurationRoot.GetConnectionString("CompanyDB");
            return new SqlConnection(conn);
        }
    }
}
