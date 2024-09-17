using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSelectDatabase_407
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=db_bank;Integrated Security=True";

            InsertEmployee(connectionString, "Bibek", "Kathmandu", 25000);
            InsertEmployee(connectionString, "Kumar", "Lalitpur", 18000);
            InsertEmployee(connectionString, "Chris", "Kathmandu", 22000);

            SelectEmployees(connectionString);
        }

        static void InsertEmployee(string connectionString, string name, string address, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tb_employee (Name, Address, Salary) VALUES (@Name, @Address, @Salary)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Salary", salary);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void SelectEmployees(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM tb_employee";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("\nEmployee Records:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Id: {reader["Id"]}\tName: {reader["Name"]}\tAddress: {reader["Address"]}\tSalary: {reader["Salary"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
