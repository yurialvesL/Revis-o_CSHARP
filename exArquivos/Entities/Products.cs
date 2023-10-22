using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exArquivos.Entities
{
    public class Products
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }


        public Products() { }

        public Products(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public List<string> Total()
        {
            List<string> produto = new List<string>();

            produto.Add(Nome);
            produto.Add((Preco * Quantidade).ToString("F2",CultureInfo.InvariantCulture));
            return produto;
        }

        public override string ToString()
        {
            return $"{Nome},{Math.Round((Preco * Quantidade),4).ToString( CultureInfo.InvariantCulture)}";
        }
    }
}
