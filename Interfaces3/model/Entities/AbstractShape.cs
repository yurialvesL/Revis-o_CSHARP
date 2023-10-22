using Interfaces3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3.model.Entities
{
    abstract public class AbstractShape :IShape
    {
        public Colors Color { get; set; }

        public abstract double Area();
    }
}
