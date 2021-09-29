using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract double Area2();
        public abstract double Area();

        public virtual void Print()
        {
            Console.WriteLine("Название = {0}", name);
        }

    }
}
