using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using métodos_abstratos.Enum;

namespace métodos_abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Enum.Color color,double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI + Math.Pow(Radius,2);
        }
    }
}
