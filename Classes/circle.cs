using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Circle : Figure
    {
        double r;
        public Circle(string name, double r) : base(name)
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
                double s;
               
                s = Math.PI * r * r;
                Console.WriteLine($"Площадь {Name} = {s}" , s);
                return s;
            }
        }
        public override double Area()
        {
            {
                double p;
               
                p = 2 * Math.PI * r;
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
