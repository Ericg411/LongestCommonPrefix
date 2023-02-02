namespace LongestCommonPrefix.Tests;

[TestClass]
public class LCPTest
{
    private readonly LongestCommonPrefix _lCP;

    public LCPTest()
    {
        _lCP = new LongestCommonPrefix();
    }

    [TestMethod]
    public void TestMethod1()
    {
        string[] strings = { "flower", "flow", "flight" };
        string result = _lCP.LongestCommonPrefixFunction(strings);

        Assert.AreEqual("fl", result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        string[] strings = { "dog", "racecar", "car" };
        string result = _lCP.LongestCommonPrefixFunction(strings);

        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        string[] strings = { "integer", "intelligence", "indecency" };
        string result = _lCP.LongestCommonPrefixFunction(strings);

        Assert.AreEqual("in", result);
    }
}