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
        public void AddShouldReturnTheAdditionOfEntryNumbersSeparatedByCommas()
        {
            string entry = "1,2";
            var result = Program.Add(entry);
            result.Should().Be(3);

            entry = "1,2,4,5";
            result = Program.Add(entry);
            result.Should().Be(12);
        }
        [Fact]
        public void AddShouldReturnTheAdditionOfEntryNumbersSeparatedByMixedSparators()
        {
            string entry = "1\n2";
            var result = Program.Add(entry);
            result.Should().Be(3);

            entry = "1\n2,4,5";
            result = Program.Add(entry);
            result.Should().Be(12);
        }
        [Fact]
        public void AddShouldReturnTheAdditionOfEntryNumbersSeparatedByDefinedDelimiters()
        {
            string entry = "//;\n1;2";
            var result = Program.Add(entry);
            result.Should().Be(3);

            entry = "//;\n1\n2;4;5";
            result = Program.Add(entry);
            result.Should().Be(12);
        }
        [Fact]
        public void AddShouldNotAcceptNagativeNumbers()
        {
            string entry = "1,4,-1";
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => Program.Add(entry));

            Assert.Equal("negatives not allowed: -1", ex.Message);

            entry = "1,4,-1,7,-8";
            ex = Assert.Throws<InvalidOperationException>(() => Program.Add(entry));

            Assert.Equal("negatives not allowed: -1,-8", ex.Message);

        }
    }
}
