
using MathTest;
[TestFixture]
public class MathTesting
{
    private BasicMath _BasicMath;
    [SetUp]
    public void Setup()
    {
        _BasicMath = new BasicMath();
    }

    [Test]
    public void TestAdd()
    {
        var result = _BasicMath.add(0.1, 0.2);
    }

    [Test]
    public void TestSubtract()
    {
        var result = _BasicMath.subtract(0.1, 0.2);
    }

    [Test]
    public void TestDivide()
    {
        var result = _BasicMath.divide(0.1, 0.2);
    }

    [Test]
    public void TestMultiplty()
    {
        var result = _BasicMath.multiply(0.1, 0.2);
    }
}