using Classes;
using System;

class Program
{
    static void Main(string[] args)
    {
        Figure refFg;
        Rectangle Re = new Rectangle("Прямоугольник", 2, 3);

        refFg = Re;
        refFg.Print();
        refFg = Re;
        refFg.Area();
        refFg = Re;
        refFg.Area2();



        Console.ReadKey();
    }
}