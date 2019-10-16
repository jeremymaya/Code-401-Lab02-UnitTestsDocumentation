using System;
using Xunit;
using UnitTestsDocumentation;

namespace UnitTestDocumentationTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanCheckBalance()
        {
            Assert.Equal(2000, Program.Balance(2000));
        }

        [Fact]
        public void CanCheckBalance5000()
        {
            Assert.Equal(5000, Program.Balance(5000));
        }
        [Fact]
        public void CanWithdawMoney100()
        {
            Assert.Equal(4900, Program.Withdraw());
        }
    }
}
