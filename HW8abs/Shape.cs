using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8abs
{
    public abstract class Shape : IComparable<Shape>
    {
        public string Name { get; protected set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}
