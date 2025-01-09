using System;
using System.Collections.Generic;

// класс, представляющий геометрическую фигуру
public class Figure
{
    // имя фигуры
    public string Name { get; set; }

    // список точек, представляющих вершины фигуры
    private List<Point> Points { get; }

    // конструктор для треугольника
    public Figure(Point p1, Point p2, Point p3)
        : this("Треугольник", new List<Point> { p1, p2, p3 }) { }

    // конструктор для четырехугольника
    public Figure(Point p1, Point p2, Point p3, Point p4)
        : this("Четырехугольник", new List<Point> { p1, p2, p3, p4 }) { }

    // конструктор для пятиугольника
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        : this("Пятиугольник", new List<Point> { p1, p2, p3, p4, p5 }) { }

    // приватный конструктор для инициализации имени и списка точек
    private Figure(string name, List<Point> points)
    {
        Name = name;  // установка имени фигуры
        Points = points; // установка вершин фигуры
    }

    // метод для вычисления длины стороны между двумя точками
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // метод для вычисления периметра фигуры
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        // сумма длины всех сторон
        for (int i = 0; i < Points.Count; i++)
        {
            perimeter += LengthSide(Points[i], Points[(i + 1) % Points.Count]);
        }
        return perimeter;
    }
}
