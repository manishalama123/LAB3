using System;

namespace Qno1
{
    public delegate void PrintMessageDelegate();

    class Program
    {
     
        public static void PrintHello()
        {
            Console.WriteLine("Hello, World!");
        }

        public static void PrintGoodbye()
        {
            Console.WriteLine("Goodbye, World!");
        }
        /*
        static void Main(string[] args)
        {
            PrintMessageDelegate messageDelegate = PrintHello;
            messageDelegate += PrintGoodbye;

           
            Console.WriteLine("Invoking multicast delegate:");
            messageDelegate();
            Console.ReadKey();

        }*/
    }
}

