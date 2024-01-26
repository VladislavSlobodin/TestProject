using System.Data.SqlClient;
using System.Text;

namespace TestProject
{
    public static class DatabaseManager
    {
        private static string _connectionString = @"Data Source=DESKTOP-QGDSMGT\SQLEXPRESS;Initial Catalog=TestDatabase1;Integrated Security=True";

        public static async Task<int> WriteAsync(List<string> entities)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            return await new SqlCommand($"INSERT INTO TestEntities VALUES {string.Join(",", entities)}", connection).ExecuteNonQueryAsync();
        }
    }
}
