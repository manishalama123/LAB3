using System;

namespace CustomExceptionDemo
{
    // Custom Exception Class
    public class InvalidAgeException : Exception
    {
        // Constructor that accepts a custom message
        public InvalidAgeException(string message) : base(message)
        {
        }

        // Constructor that accepts custom message and inner exception
        public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Throw the custom exception if age is less than 18
                if (age < 18)
                {
                    throw new InvalidAgeException("Age must be 18 or above.");
                }
                else
                {
                    Console.WriteLine("Your age is: " + age);
                }
            }
            catch (InvalidAgeException ex)
            {
                // Handle the custom exception
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other general exception
                Console.WriteLine("General Exception Caught: " + ex.Message);
            }
            Console.ReadKey();
        }*/
    }
}
