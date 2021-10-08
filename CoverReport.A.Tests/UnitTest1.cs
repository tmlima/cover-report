using CoverReport.Services;
using System;
using Xunit;

namespace CoverReport.A.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, new Class1().A());
        }
    }
}
