using System;
using System.IO;
using Xunit;

namespace Program.Tests
{
    public class LeapYearTests
    {
        [Fact]
        public void leap_year_returns_true()
        {
            var leapYear = new LeapYear();
            Assert.True(leapYear.IsLeapYear(2000));
            Assert.True(leapYear.IsLeapYear(1600));
            Assert.True(leapYear.IsLeapYear(1808));
            Assert.True(leapYear.IsLeapYear(1860));
            Assert.True(leapYear.IsLeapYear(1884));
            Assert.True(leapYear.IsLeapYear(1928));
            Assert.True(leapYear.IsLeapYear(1972));
            Assert.True(leapYear.IsLeapYear(2064));
        }

        [Fact]
        public void leap_year_returns_false()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(1900));
            Assert.False(leapYear.IsLeapYear(1921));
            Assert.False(leapYear.IsLeapYear(1809));
            Assert.False(leapYear.IsLeapYear(2021));
            Assert.False(leapYear.IsLeapYear(1985));
            Assert.False(leapYear.IsLeapYear(1914));
        }
    }
}
