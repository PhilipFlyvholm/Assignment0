using System;

namespace Program
{
    public class LeapYear
    {
        public void promtUserInput()
        {
            Console.WriteLine("Type an year and press enter");
            var input = Console.ReadLine();
            promtUserInput(input);
        }
        public void promtUserInput(string input)
        {
            try
            {
                int inputValue = Convert.ToInt32(input);
                Console.WriteLine(IsLeapYear(inputValue) ? "Yay" : "Nay");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                promtUserInput();
            }
        }

        public bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new ArgumentException("Year must be higher than 1582");
            }
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }

}