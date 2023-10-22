using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    sealed class SavingsAccount :Account //Palavara chave sealed é usada para evitar que a classe seja herdada por outra classe
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //sobrescrevendo um método da super classe, e a palavra sealed é para ele não ser sobreposto novamente em outra subclasse
        {
            Balance -= amount;
        }

    }
}
