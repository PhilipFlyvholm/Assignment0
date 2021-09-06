using System;

namespace Program
{
    public class LeapYear
    {
        public void promtUserInput()
        {
            Console.WriteLine("Type an year and press enter");
            var input = Console.ReadLine();
            int inputValue = Convert.ToInt32(input);
            Console.WriteLine(IsLeapYear(inputValue) ? "Yay" : "Nay");
        }

        public bool IsLeapYear(int year)
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }

}