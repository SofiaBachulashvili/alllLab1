using System;
using Xunit;

public class FigureTests
{
    [Fact]
    public void TestPerimeterCalculator()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 1);
        Point p3 = new Point(1, 1);
        Figure triangle = new Figure(p1, p2, p3);

        double expectedPerimeter = Math.Sqrt(2) + 1 + 1; // ������ ���������� ���������
        Assert.Equal(expectedPerimeter, triangle.PerimeterCalculator());
    }
}
