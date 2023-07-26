namespace AreaCalculate.impl;

 class CircleAreaCalculator : IAreaCalculator
{
    public  double FindArea(AreaCalculatorData areaCalculatorData)
    {
        var circleAreaData = (CircleAreaData)areaCalculatorData;
        return Math.PI * (circleAreaData.Radius * circleAreaData.Radius);
    }

    public bool CanCalculate(AreaCalculatorData areaCalculatorData)
    {
        return areaCalculatorData.GetType().IsAssignableFrom(typeof(CircleAreaData));
    }
}