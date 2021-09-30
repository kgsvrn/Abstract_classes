using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class circle : Figure
    {
        double r;
        public circle(string name, double r) : base(name)
        {
            if (r > 0)
            {
                this.r = r;
            }
            else
            {
                Console.WriteLine("Значение меньше нуля");
                Console.WriteLine("Стандартные  r=1");
                this.r = 1; 
            }
        }
        public void SetR(double r)
        {
            if (r > 0)
            {
                this.r = r;
            }
            else
            {
                this.r = 1;
            }
        }
        public void GetR(out double r)
        {
            r = this.r;
        }
        public override double Area2()
        {
            {
                double s, pi;
                pi = 3.14159265359;
                s = pi * r * r;
                Console.WriteLine($"Площадь {Name} = {s}" , s);
                return s;
            }
        }
        public override double Area()
        {
            {
                double p, pi;
                pi = 3.14159265359;
                p = 2 * pi * r;
                Console.WriteLine($"Периметр {Name} = {p}", p);
                return p;
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус = {r}");
        }
    }
}
