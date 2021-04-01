using System;
using Xunit;
using FluentAssertions;
using F1zzB2zzCsh4rp;

namespace F1zzB2zzCsh4rpTests
{
    public class UnitTest1
    {
        private FbRenderer _testSubject = new FbRenderer();

        [Fact]
        public void should_create_fizzbuzz_renderer() => _testSubject.Should().NotBeNull();

        [Fact]
        public void should_render_1_as_1() => _testSubject.render(1).Should().Be("1");

        [Fact]
        public void should_render_2_as_2() => _testSubject.render(2).Should().Be("2");

        [Fact]
        public void should_render_3_as_Fizz() => _testSubject.render(3).Should().Be("Fizz");

        [Fact]
        public void should_render_5_as_Buzz() => _testSubject.render(5).Should().Be("Buzz");

        [Fact]
        public void should_render_6_as_Fizz() => _testSubject.render(6).Should().Be("Fizz");

        [Fact]
        public void should_render_9_as_Fizz() => _testSubject.render(9).Should().Be("Fizz");

        [Fact]
        public void should_render_15_as_FizzBuzz() => _testSubject.render(15).Should().Be("FizzBuzz");

        [Fact]
        public void should_render_60_as_FizzBuzz() => _testSubject.render(60).Should().Be("FizzBuzz");

        [Fact]
        public void should_render_68_as_68() => _testSubject.render(68).Should().Be("68");
    }
}
