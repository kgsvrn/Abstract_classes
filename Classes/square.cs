using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Square : Figure
    {
        double a, b;
        public Square(string name, double a) : base(name)
        {
            if (a > 0 )
            {
                this.a = a; 
            }
            else
            {
                Console.WriteLine("Значение меньше нуля");
                Console.WriteLine("Стандартные  a=1 ");
                this.a = 1; 
            }
        }
        public void SetAB(double a)
        {
            if (a > 0 )
            {
                this.a = a; 
            }
            else
            {
                this.a = 1; 
            }
        }
        public void GetAB(out double a)
        {
            a = this.a;
        }
        public override double Area2()
        {
            {
                double s;
                s = a * a;
                Console.WriteLine($"Площадь {Name}= {s} ", s);
                return s;
            }
        }
        public override double Area()
        {
            {
                double p;
                p = 4 * a;
                Console.WriteLine($"Периметр {Name} = {p}", p);
                return p;
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"a = {a}", a);
           
        }
    }
}
