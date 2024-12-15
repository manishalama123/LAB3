using System;
using MySql.Data.MySqlClient;

class Program3
{
    static string connectionString = "Server=localhost;Database=lab3;Uid=root;Pwd='';";

   /* static void Main()
    {
        // Create: Add new employee
        CreateEmployee("Manisha Lama", 55000, "Kathmandu");

        // Read: Get employee details
        ReadEmployee(4);

        // Update: Change employee details
        UpdateEmployee(5, "Rajesh Hamal", 60000, "Patan");

        // Delete: Remove employee
        DeleteEmployee(4);
        Console.ReadKey();
    }*/
    
    // Create: Insert new employee
    static void CreateEmployee(string name, decimal salary, string address)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Employees (Name, Salary, Address) VALUES (@name, @salary, @address)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Employee added successfully.");
            }
        }
    }

    // Read: Get employee by ID
    static void ReadEmployee(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Employees WHERE ID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}, Salary: {reader["Salary"]}, Address: {reader["Address"]}");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }
            }
        }
    }

    // Update: Modify employee details
    static void UpdateEmployee(int id, string name, decimal salary, string address)
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

    // Delete: Remove employee by ID
    static void DeleteEmployee(int id)
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
