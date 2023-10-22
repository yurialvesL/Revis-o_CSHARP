using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception_ex.Exception;

namespace Exception_ex.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount)
        {
            try
            {
                if (amount > Balance && amount < WithdrawLimit)
                {
                    throw new AccountException("Saldo insuficiente");
                }
                else if (amount > WithdrawLimit)
                {
                    throw new AccountException("O limite de saque foi ultrapassado");
                }
                else if(amount < 0)
                {
                    throw new AccountException("Não é possivel sacar valor negativo");
                    
                }
                else
                {
                    Balance-=amount;
                    Console.WriteLine($"New Balance:{Balance}");
                }
            }
            catch (AccountException a)
            {
                Console.WriteLine(a.Message);
                
            }
           
        }
    }
}
