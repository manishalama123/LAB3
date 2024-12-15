using System;
using MySql.Data.MySqlClient;

class Program1
{
   /* static void Main()
    {
        string connectionString = "Server=localhost;Database=lab3;Uid=root;Pwd='';";

        // Update employee record
        UpdateEmployee(connectionString, 4, "Harshika Magar", 65000, "Patan");

        // Delete employee record
        DeleteEmployee(connectionString, 3);
        Console.ReadKey();
    }
    */
    // Method to Update an employee record
    static void UpdateEmployee(string connectionString, int id, string name, decimal salary, string address)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE Employees SET Name = @name, Salary = @salary, Address = @address WHERE ID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Employee updated successfully.");
            }
        }
    }

    // Method to Delete an employee record
    static void DeleteEmployee(string connectionString, int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM Employees WHERE ID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Employee deleted successfully.");
            }
        }
    }
}
