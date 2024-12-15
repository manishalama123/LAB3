using System;

namespace ExceptionDemo
{
    class Program
    {
       /* static void Main(string[] args)
        {
            try
            {
                // Code that may throw an exception
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                // Simulating an exception: divide by zero
                int result = 10 / number;
                Console.WriteLine("Result is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                // Catching a specific exception
                Console.WriteLine("Error: Cannot divide by zero!");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (FormatException ex)
            {
                // Catching format exception (if user input is not a number)
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Catching any other general exceptions
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // This block always runs, even if there was an exception
                Console.WriteLine("Execution completed.");
            }

            Console.ReadLine(); // Keep the console window open
            Console.ReadKey();
        }*/
    }
}
