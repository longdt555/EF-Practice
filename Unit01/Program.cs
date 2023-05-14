using System.Data.SqlClient;

namespace Unit01
{
    internal class Program
    {
        /// <summary>
        /// /
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // object đảm nhiệm việc kết nối
            var connection = new SqlConnection
            {
                // chuỗi ký tự chứa tham số phục vụ kết nối
                ConnectionString = @"Data Source=localhost;Initial Catalog=Contacts;Integrated Security=True"
            };
            // object đảm nhiệm việc thực thi truy vấn
            var command = new SqlCommand()
            {
                Connection = connection,
                CommandText = "SELECT COUNT(*) FROM CONTACTS"
            };
            // thử mở kết nối
            connection.Open();
            // thực thi truy vấn và lấy kết quả
            // phương thức ExecuteScalar của SqlCommand chỉ trả lại duy nhất một giá trị thuộc kiểu object. Do đó, nó chỉ phù hợp để đọc các giá trị thống kê từ Sql Server.
            var res = (int)command.ExecuteScalar();
            // đóng kết nối
            connection.Close();
            Console.WriteLine($"{res} contacts found in the database");
            Console.ReadLine();
        }
    }
}