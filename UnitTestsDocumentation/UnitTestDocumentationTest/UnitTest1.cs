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
        [Theory]
        [InlineData(3500.50, 5000, 1499.50)]
        [InlineData(4000, 5000, 1000)]
        public void CanWithdawMoney(decimal endBalance, decimal startBalance, decimal withdrawal)
        {
            Assert.Equal(endBalance, Program.Withdraw(startBalance, withdrawal));
        }
        [Theory]
        [InlineData(3500.50, 5000, 1499.50)]
        [InlineData(4000, 5000, 1000)]
        public void CanDepositMoney(decimal endBalance, decimal startBalance, decimal deposit)
        {
            Assert.Equal(endBalance, Program.Withdraw(startBalance, deposit));
        }
    }
}
