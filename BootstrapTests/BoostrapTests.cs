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
    }
}
