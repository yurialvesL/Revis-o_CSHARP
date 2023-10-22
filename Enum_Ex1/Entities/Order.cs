using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Enum_Ex3.

namespace Enum_Ex1.Entities
{
    class Order
    {
        public DateTime Moment { get; } = DateTime.Now;

        public OrderStatus status { get; set; }
    }
}
