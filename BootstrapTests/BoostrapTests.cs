using boostrap_DotnetCore;
using FluentAssertions;
using System;
using System.Text;
using Xunit;

namespace BootstrapTests
{
    public class BoostrapTests
    {
        [Fact]
        public void AddShouldReturnEmptyString()
        {
            var result = Program.Add("");
            result.Should().Be(0);
        }
        [Fact]
        public void AddShouldReturnSameNumber()
        {
            string entry = "1";
            var result = Program.Add(entry);
            result.Should().Be(1);
        }
        [Fact]
        public void AddShouldReturnTheAdditionOfEntryNumbers()
        {
            string entry = "1,2";
            var result = Program.Add(entry);
            result.Should().Be(3);
        }
    }
}
