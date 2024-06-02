namespace test;
using Xunit;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var one = 1;
        var two = 2;
        var result = one + two;
        Assert.Equal(3, result);
    }
}