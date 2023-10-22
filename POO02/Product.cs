using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO02
{
    class Product
    {
        public string Name;
        public double Price;
        public int Qtd;


        public double ValorTotalEstoque()
        {
            return Price * Qtd;

        }
        public void AddProd(int qtd)
        {
            Qtd += qtd;

           
        }
        public void RemoveProd()
        {
            Qtd -= Qtd;
        }
    }
}
