using ConsoleApp1.Services;

namespace ConsoleApp1.Test;

public class UnitTest1
{
    [Fact]
    public void ConsoleApp1_PrimeService_Test1()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(1);
        Assert.False(result, "1 should not be prime");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    [InlineData(0)]
    [InlineData(2)]
    public void ConsoleApp1_PrimeService_TestMany(int value)
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(value);
        Assert.False(result, $"{value} should not be prime");
    }
}