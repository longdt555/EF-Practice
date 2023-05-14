using System.Data;
using System.Data.SqlClient;

namespace Unit03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var connectionString = @"Data Source=localhost;Initial Catalog=Contacts;Integrated Security=True";
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM CONTACTS";
                var dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            foreach (DataRow r in dataTable.Rows)
            {
                var id = (int)r["Id"];
                var contactName = (string)r["ContactName"];
                var alias = (string)r["Alias"];
                Console.WriteLine($"[{id}] {contactName} ({alias})");
            }
            Console.ReadLine();
        }
    }
}