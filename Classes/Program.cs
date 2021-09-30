using Classes;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double sumSquare = 0, sumP = 0;
        List<Figure> figures = new List<Figure>();
        figures.Add(new Circle("Круг1", 2));
        figures.Add(new Circle("Круг2", 3));
        figures.Add(new Rectangle("Прямоугольник1", 3, 3));
        figures.Add(new Rectangle("Прямоугольник2", 6, 2));
        figures.Add(new Trapezoid("Трапеция1", 1, 4, 8, 8, 2));
        figures.Add(new Triangle(" Треугольник1", 1, 4, 1, 1));
        figures.Add(new Square("Квадрат1", 8));
        foreach (var figure in figures)
        {
            sumP  += figure.Area();
            sumSquare += figure.Area2();
        }
        Console.WriteLine($"Сумма периметров {sumP} " , sumP);
        Console.WriteLine($"Сумма площадей {sumSquare} ", sumSquare);
        Console.ReadKey();
    }
}
