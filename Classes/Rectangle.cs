using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Rectangle : Figure
    {
        double a, b;
        public Rectangle(string name, double a, double b) : base(name)
        {
            if (a > 0 && b > 0)
            {
                this.a = a; this.b = b;
            }
            else
            {
                Console.WriteLine("Значение меньше нуля");
                Console.WriteLine("Стандартные  a=1 b=2");
                this.a = 1; this.b = 2;
            }
        }
        public void SetAB(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                this.a = a; this.b = b;
            }
            else
            {
                this.a = 1; this.b = 2;
            }
        }
        public void GetAB(out double a, out double b)
        {
            a = this.a; b = this.b;
        }
        public override double Area2()
        {
            {
                double s;
                s = a * b;
                Console.WriteLine($"Площадь {Name}= {s} " , s);
                return s;
            }
        }
        public override double Area()
        {
            {
                double p;
                p = 2 * (a + b);
                Console.WriteLine($"Периметр {Name} = {p}", p);
                return p;
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(@"a = "+ a);
            Console.WriteLine($"b = {b}", b);
        }
    }
}
