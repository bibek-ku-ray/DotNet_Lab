using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDatabase_407
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True; Database=db_bank";

            string insertQuery = @"
            INSERT INTO tb_customer (Account_no, Name, Address, Balance)
            VALUES 
            (101, 'Rusis', 'Kathmandu', 7000),
            (102, 'Pramod', 'Kathmandu', 4000),
            (103, 'Anoz', 'Bhaktapur', 10000),
            (104, 'Sameer', 'Kandaghari', 3000),
            (105, 'Ayush', 'Malta', 8000);";

            string selectQuery = "SELECT * FROM tb_customer WHERE Balance > 5000";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        int rowsInserted = insertCommand.ExecuteNonQuery();
                        Console.WriteLine($"{rowsInserted} customer records inserted successfully.\n");
                    }

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataReader reader = selectCommand.ExecuteReader();
                        Console.WriteLine("Customers with Balance greater than 5000:");

                        while (reader.Read())
                        {
                            Console.WriteLine($"Account_no: {reader["Account_no"]}");
                            Console.WriteLine($"Name: {reader["Name"]}");
                            Console.WriteLine($"Address: {reader["Address"]}");
                            Console.WriteLine($"Balance: {reader["Balance"]}");
                            Console.WriteLine("------------------------------------------------");

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
