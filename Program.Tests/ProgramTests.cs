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
            HelloWorld.PrintHelloWorld();
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", output);
        }
    }
}
