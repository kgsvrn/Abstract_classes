using Classes;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double sumSquare = 0, sumP = 0;
        List<Figure> figures = new List<Figure>();
        figures.Add(new circle("Круг1", 2));
        figures.Add(new circle("Круг2", 3));
        figures.Add(new Rectangle("Прямоугольник1", 3, 3));
        figures.Add(new Rectangle("Прямоугольник2", 6, 2));
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
