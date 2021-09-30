using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Trapezoid : Figure
    {
        double a, b, c, d, h;
        public Trapezoid(string name, double a, double b, double c, double d , double h) : base(name)
        {
            if (a > 0 && b >0 && h > 0)
            {
                this.a = a;
                this.b = b;
                this.h = h;
                this.c = c;
                this.d = d;
            }
            else
            {
                Console.WriteLine("Значение меньше нуля  ");
                Console.WriteLine("Приведено к стандартным");
                this.a = 1;
                this.b = 2;
                this.h = 1;
                this.c = 1;
                this.d = 1;
            }
        }
        public void SetABH(double a, double b, double h, double c, double d)
        {
            if (a > 0 && b > 0 && h > 0 && c > 0 && d > 0)
            {
                this.a = a;
                this.b = b;
                this.h = h;
                this.c = c;
                this.d = d;
            }
            else
            {
                this.a = 1;
                this.b = 2;
                this.h = 1;
                this.c = 1;
                this.d = 1;
            }
        }
        public void GetABH(out double a, out double b, out double h, double c, double d)
        {
            a = this.a;
            b = this.b;
            h = this.h;
            c = this.c;
            d = this.d;
        }
        public override double Area2()
        {
            {
                double s;
                s = (a + b) * h * 0.5; 
                Console.WriteLine($"Площадь {Name} = {s}", s);
                return s;
            }
        }
        public override double Area()
        {
            {
                double p;
                p = a + b + c + d;
                Console.WriteLine($"Периметр {Name} = {p}", p);
                return p;
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"a = {a}", a);
            Console.WriteLine($"b = {b}", b);
            Console.WriteLine($"c = {c}", c);
            Console.WriteLine($"d = {d}", d); 
            Console.WriteLine($"h = {h}", h);
        }
    }
}
