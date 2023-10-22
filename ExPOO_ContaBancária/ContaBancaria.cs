using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPOO_ContaBancária
{
    internal class ContaBancaria
    {
        private double taxa = 5;
        public string _conta { get; set; }
        public string _nome { get; set; }

        public double _saldo  { get; set; }
        public ContaBancaria(string conta, string nome)
        {
            _conta = conta;
            _nome = nome;
            _saldo = 0;
        }

        public ContaBancaria(string conta, string nome, double saldo)
        {
            _conta = conta;
            _nome=nome;
            _saldo = saldo; 
        }

        public void deposito(double valor)
        {
            _saldo += valor;
        }

        public void saque(double valor)
        {
            
            _saldo -= valor;
            _saldo -= taxa;

            
        }
    }
}
