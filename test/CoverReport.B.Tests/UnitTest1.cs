using CoverReport.Services;
using System;
using Xunit;

namespace CoverReport.B.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestB()
        {
            Assert.Equal(2, new Class1().B());
        }
    }
}
