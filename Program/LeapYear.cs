using System;

namespace Program
{
    public class LeapYear
    {

        public bool IsLeapYear(int year)
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }

}