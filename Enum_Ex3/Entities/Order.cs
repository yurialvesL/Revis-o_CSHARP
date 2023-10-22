using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Enum_Ex3.Entities.Enum;
using Microsoft.VisualBasic;

namespace Enum_Ex3.Entities
{
    class Order
    {
        public DateTime Moment { get; } = DateTime.Now;

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client_ { get; set; } = new Client();

        public Order() { }

        public Order( OrderStatus status, Client client_)
        {

            Status = status;
            Client_ = client_;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) 
        {  
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items) 
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            double totalPrice = 0;
           StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment:");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status:");
            sb.Append(Status.ToString());
            sb.AppendLine("Client: ");
            sb.Append(Client_.Name+" ");
            sb.Append($"({Client_.BirthDate.ToString("dd/MM/yyyy")}) - ");
            sb.Append(Client_.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.ToString());
                totalPrice += item.SubTotal();
            }
            sb.AppendLine("Total price: ");
            sb.Append("$"+totalPrice.ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
