using AreaCalculate;
using AreaCalculate.impl;

namespace AreaTest;

public class CircleAreaTests
{
    private AreaCalculator _areaCalculator;

    [SetUp]
    public void Setup()
    {
        _areaCalculator = new AreaCalculator();
    }

    [Test]
    public void TestCircleAreaWithDoubleFractionResult()
    {
        var area = _areaCalculator.FindArea(new CircleAreaData() { Radius = 6 });
        Assert.True(NearlyEqual(area,113.0973, 1e-5));
    }
    
    [Test]
    public void TestCircleAreaWithoutFractionAreaResult()
    {
        var area = _areaCalculator.FindArea(new CircleAreaData() { Radius = 7.978845608 });
        Assert.True(NearlyEqual(area,200, 1e-5));
    }

    private static bool NearlyEqual(double a, double b, double epsilon) {
        double absA = Math.Abs(a); 
        double absB = Math.Abs(b);
        double diff = Math.Abs(a - b);

        if (a == b) { 
            return true;
        } else if (a == 0 || b == 0 || (absA + absB < double.MinValue)) {
            return diff < (epsilon * double.MinValue);
        } else { 
            return diff / Math.Min((absA + absB), double.MaxValue) < epsilon;
        }
    }

}