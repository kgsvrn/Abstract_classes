using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Triangle : Figure
    {
        double a, b, c, d, h;
        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            if (a > 0 && b > 0 && h > 0)
            {
                this.a = a;
                this.b = b;
                this.h = h;
                this.c = c;
             
            }
            else
            {
                Console.WriteLine("Значение меньше нуля ");
                Console.WriteLine("Приведено к стандартным");
                this.a = 1;
                this.b = 2;
                this.h = 1;
                this.c = 1;
               
            }
        }
        public void SetABH(double a, double b, double h, double c)
        {
            if (a > 0 && b > 0 && h > 0 && c > 0 )
            {
                this.a = a;
                this.b = b;
                this.h = h;
                this.c = c;
               
            }
            else
            {
                this.a = 1;
                this.b = 2;
                this.h = 1;
                this.c = 1;
               
            }
        }
        public void GetABH(out double a, out double b, out double h, double c)
        {
            a = this.a;
            b = this.b;
            h = this.h;
            c = this.c;
           
        }
        public override double Area2()
        {
            {
                double s;
                s = a * h * 0.5;
                Console.WriteLine($"Площадь {Name} = {s}", s);
                return s;
            }
        }
        public override double Area()
        {
            {
                double p;
                p = a + b + c;
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
         
            Console.WriteLine($"h = {h}", h);
        }
    }
}
