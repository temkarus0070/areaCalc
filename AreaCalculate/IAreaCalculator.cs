using AreaCalculate.impl;

namespace AreaCalculate;

public interface IAreaCalculator
{
    public double FindArea(AreaCalculatorData areaCalculatorData);

    public bool CanCalculate(AreaCalculatorData areaCalculatorData);
}