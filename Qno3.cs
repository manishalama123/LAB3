using System;
using MySql.Data.MySqlClient; // Add this namespace for MySQL connection

class Program
{
    /*static void Main()
    {
        // Update this connection string with your MySQL database details
        string connectionString = "Server=localhost;Database=lab3;Uid=root;Pwd='';";

        // Call the Insert and Select methods
        InsertEmployee(connectionString, "Manisha Lama", 70000, "Dharan");
        SelectEmployees(connectionString);
        Console.ReadKey();
    }*/

    // Method to Insert a record into the Employees table
    static void InsertEmployee(string connectionString, string name, decimal salary, string address)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Open the database connection
                string query = "INSERT INTO Employees (Name, Salary, Address) VALUES (@name, @salary, @address)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery(); // Execute the query
                    Console.WriteLine("Employee inserted successfully.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Method to Select and display all records from the Employees table
    static void SelectEmployees(string connectionString)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Open the database connection
                string query = "SELECT * FROM Employees";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("ID\tName\t\tSalary\t\tAddress");
                    Console.WriteLine("---------------------------------------------");

                    while (reader.Read())
                    {
                        // Display the retrieved data
                        Console.WriteLine($"{reader["ID"]}\t{reader["Name"]}\t{reader["Salary"]}\t{reader["Address"]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

