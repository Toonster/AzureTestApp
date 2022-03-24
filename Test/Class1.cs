using Xunit;

namespace Test;

public class Class1
{
    [Fact]
    public void Fail()
    {
        Assert.True(false);
    }
}