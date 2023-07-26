namespace AreaCalculate.impl;

 class TriangleAreaCalculator : IAreaCalculator
{
    public  double FindArea(AreaCalculatorData areaCalculatorData)
    {
        var triangleAreaData = (TriangleAreaData)areaCalculatorData;
        if (triangleAreaData.SidesLength.Count != 3)
        {
            throw new ArgumentException("Для вычисления площади треугольника нужны длины 3х сторон");
        }

        if (CanCalcArea(triangleAreaData))
        {
            var p = triangleAreaData.SidesLength.Sum() / 2;
            double myltiply = p;
            for (int i = 0; i < triangleAreaData.SidesLength.Count; i++)
            {
                myltiply *= (p - triangleAreaData.SidesLength[i]);
            }

            return Math.Sqrt(myltiply);
        }
        else
        {
            throw new ArgumentException(
                "Неверно указаны стороны треугольника и не выполняется основное свойство треугольников");
        }
    }

    private bool CanCalcArea(TriangleAreaData triangleAreaData)
    {
        return triangleAreaData.SidesLength[0] + triangleAreaData.SidesLength[1] > triangleAreaData.SidesLength[2] &&
               triangleAreaData.SidesLength[1] + triangleAreaData.SidesLength[2] > triangleAreaData.SidesLength[0]
               && triangleAreaData.SidesLength[2] + triangleAreaData.SidesLength[0] > triangleAreaData.SidesLength[1];
    }

    public  bool CanCalculate(AreaCalculatorData areaCalculatorData)
    {
        return areaCalculatorData.GetType().IsAssignableFrom(typeof(TriangleAreaData));
    }
}