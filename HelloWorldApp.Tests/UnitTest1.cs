namespace HelloWorldApp.Tests;

using NUnit.Framework;
using HelloWorldApp;
using HelloWorldApp.Web;

public class MathOperationsTests
{
    [Test()]
    public void AddTest()
    {
        MathOperations bm = new MathOperations();
        double res = bm.Add(10, 10);
        Assert.AreEqual(20, res);
    }
    [Test()]
    public void SubtractTest()
    {
        MathOperations bm = new MathOperations();
        double res = bm.Subtract(10, 10);
        Assert.AreEqual(0, res);
    }
    [Test()]
    public void DivideTest()
    {
        MathOperations bm = new MathOperations();
        double res = bm.Divide(10, 5);
        Assert.AreEqual(2, res);
    }
    [Test()]
    public void MultiplyTest()
    {
        MathOperations bm = new MathOperations();
        double res = bm.Multiply(10, 5);
        Assert.AreEqual(50, res);
    }
}