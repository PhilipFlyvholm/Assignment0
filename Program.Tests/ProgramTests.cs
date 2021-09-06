using System;
using System.IO;
using Xunit;

namespace Program.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_hello_world()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            HelloWorld.Main(new String[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", output);
        }
    }
}
