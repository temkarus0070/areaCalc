using AreaCalculate.impl;

namespace AreaCalculate;

public class AreaCalculator
{
    private readonly List<IAreaCalculator> _areaCalculators = new List<IAreaCalculator>();

    public AreaCalculator()
    {
        _areaCalculators.Add(new CircleAreaCalculator());
        _areaCalculators.Add(new TriangleAreaCalculator());
    }

    public  double FindArea(AreaCalculatorData areaCalculatorData)
    {
        foreach (var areaCalculator in _areaCalculators)
        {
            if (areaCalculator.CanCalculate(areaCalculatorData))
            {
                return areaCalculator.FindArea(areaCalculatorData);
            }
        }

        throw new NotImplementedException("Поддержка расчета площади для данного типа еще не реализована");
    }

    public bool CanCalculate(AreaCalculatorData areaCalculatorData)
    {
        foreach (var areaCalculator in _areaCalculators)
        {
            if (areaCalculator.CanCalculate(areaCalculatorData))
            {
                return true;
            }
        }

        return false;
    }
}