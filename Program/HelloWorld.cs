using System;

namespace Program
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            var leapYear = new LeapYear();
            try
            {
                leapYear.promtUserInput();
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be an integer");
                Main(args);
            }
        }

        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");

        }
    }
}
