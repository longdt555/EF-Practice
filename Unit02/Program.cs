using System.Data;
using System.Data.SqlClient;

namespace Unit02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = @"Data Source=localhost;Initial Catalog=Contacts;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("SELECT * FROM CONTACTS", connection);
            connection.Open();
            var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var id = dataReader.GetInt32(0);
                    var contactName = dataReader.GetString(1);
                    var alias = dataReader.GetString(2);
                    Console.WriteLine($"[{id}] {contactName} ({alias})");
                }
            }
            Console.ReadLine();
        }
    }
}