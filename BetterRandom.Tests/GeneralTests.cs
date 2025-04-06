namespace BetterRandom.Tests;
using BetterRandom;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        Random rand = new Random();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
