using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Ex3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }


        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name+", ");
            sb.Append("$"+Price+", ");
            sb.Append("Quantity: ");
            sb.Append(Quantity+", ");
            sb.Append("Subtotal: ");
            sb.Append("$"+this.SubTotal().ToString());
            return sb.ToString();
        }
    }
}
