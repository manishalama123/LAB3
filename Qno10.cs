using System;
using MySql.Data.MySqlClient;

class Program123
{
    static string connectionString = "Server=localhost;Database=TourismInfoDB;Uid=root;Pwd='';";

   /* static void Main()
    {
        // Save new tourism destination
        SaveTourismInfo("Mount Everest", "The highest mountain in the world.", "5 days", DateTime.Now);
      */

    // Save tourism information to the database
    static void SaveTourismInfo(string title, string description, string duration, DateTime createdDate)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Tour_Destination (Title, Description, Duration, CreatedDate) VALUES (@title, @description, @duration, @createdDate)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@createdDate", createdDate);

                // Execute the query
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tourism information saved successfully.");
            }
        }
    }
}
