namespace StringFirstOcc.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        var haystack = "sadbutsad";
        var needle = "sad";
        var result = _test.StrStr(haystack, needle);
        Assert.AreEqual(0, result);

    }  
    [TestMethod]
    public void TestMethod2()
    {
        var haystack = "leetcode";
        var needle = "leeto";
        var result = _test.StrStr(haystack, needle);
        Assert.AreEqual(-1, result);

    }
}