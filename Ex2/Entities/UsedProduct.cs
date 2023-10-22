using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime manufactureDate):base(name,price) 
        {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return  $"{base.Name} (used) $ {base.Price} (Manufacture Date:{manufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
