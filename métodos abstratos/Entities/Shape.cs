using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using métodos_abstratos.Enum;

namespace métodos_abstratos.Entities
{
    abstract class Shape
    {
        public Enum.Color _Color { get; set; }

        public Shape(){ }

        public Shape(Enum.Color _color)
        {
            _Color = _color;
        }

        public abstract double Area();
    }
}
