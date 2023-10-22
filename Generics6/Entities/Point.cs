using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics6.Entities
{
    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y): this()
        {
            x = x;
            y = y;

        }
    }
}
