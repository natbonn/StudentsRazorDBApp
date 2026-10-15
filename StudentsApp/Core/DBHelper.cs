using Microsoft.Data.SqlClient;

namespace StudentsApp.Core
{
    public class DBHelper
    {
        private readonly string _connectionString;

        // Interface .NET
        public DBHelper(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"]!;
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }


    }
}
