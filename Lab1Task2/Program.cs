
/*
Задание 2
Создайте класс с именем Rectangle.

В теле класса создайте два поля, описывающие длины сторон double sideA, sideB.
Создайте пользовательский конструктор Rectangle(double sideA, double sideB), в 
теле которого поля sideA и sideB инициализируются значениями аргументов.

Создайте два private метода: 
- вычисляющий площадь прямоугольника - double CalculateArea()
- вычисляющий периметр прямоугольника - double CalculatePerimeter ()

Создайте два свойства double Area и double Perimeter с одним методом доступа get,
вызывающим созданные ранее методы.

Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника
и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle.
*/

using System;


class Rectangle
{
    private double sideA;
    private double sideB;
    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }
    private double CalculateArea()
    {
        return sideA * sideB;
    }

    private double CalculatePerimeter() // => -  {return 2*(sideA + sideB); }
    {
        return 2 * (sideA + sideB);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);
        Console.WriteLine($"Area: {rectangle.Area}");
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

        Console.WriteLine();
    }
}
