using System;

namespace Program
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            var leapYear = new LeapYear();
            leapYear.promtUserInput();
        }
        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");

        }
    }
}
