using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }


        public override string ToString()
        {
            return $"{Name},{Value}";
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("The object is not a Product");
            }
            Product other = obj as Product;
            return Value.CompareTo(other.Value);
        }
    }
}
