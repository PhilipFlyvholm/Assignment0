using System;
using System.IO;
using Xunit;

namespace Program.Tests
{
    public class LeapYearTests
    {
        [Fact]
        public void is_leap_year_returns_true()
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
        public void is_leap_year_returns_false()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(1900));
            Assert.False(leapYear.IsLeapYear(1921));
            Assert.False(leapYear.IsLeapYear(1809));
            Assert.False(leapYear.IsLeapYear(2021));
            Assert.False(leapYear.IsLeapYear(1985));
            Assert.False(leapYear.IsLeapYear(1914));
        }

        [Fact]
        public void is_leap_year_throws_exception()
        {
            var leapYear = new LeapYear();
            Assert.Throws<ArgumentException>(new Action(() =>
            {
                leapYear.IsLeapYear(1400);
            }));
        }

        [Fact]
        public void promt_user_input_throws_exception()
        {
            var leapYear = new LeapYear();
            Assert.Throws<FormatException>(new Action(() =>
            {
                leapYear.promtUserInput("Hello");
            }));
        }

    }
}
