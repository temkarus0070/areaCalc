using AreaCalculate;
using AreaCalculate.impl;

namespace AreaTest;

public class TriangleAreaTests
{
    private AreaCalculator _areaCalculator;

    [SetUp]
    public void Setup()
    {
        _areaCalculator = new AreaCalculator();
    }

    [Test]
    public void TestTriangleAreaOnDifferentSides()
    {
        var area = _areaCalculator.FindArea(new TriangleAreaData() { SidesLength = new List<double>() { 3, 4, 5 } });
        Assert.That(area, Is.EqualTo(6));
    }  
    [Test]
    public void TestTriangleAreaOnWithTwoEqualSides()
    {
        var area = _areaCalculator.FindArea(new TriangleAreaData() { SidesLength = new List<double>() {5,5,8 } });
        Assert.That(area, Is.EqualTo(12));
    }
    
    
}