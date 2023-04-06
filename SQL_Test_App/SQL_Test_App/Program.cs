using Microsoft.Data.SqlClient;
namespace SQL_Test_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-IRQ8TH4; Integrated Security=True; Encrypt=False; Initial Catalog=TestDB";
            SqlConnection connection = new SqlConnection(connectionString);
            
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM employee", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["emp_id"] + " "+ reader["emp_name"]);
                }
                reader.Close();
                connection.Close();
                Console.ReadLine();
        }
    }
}








