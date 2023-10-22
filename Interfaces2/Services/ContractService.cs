using Interfaces2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Interfaces2.Services
{
    public class ContractService
    {

        public void processContract(Contract contract, int months)
        {
            PaypalService paypalService = new PaypalService();
            DateTime dataParcela = contract.Date;
            double valorParcela = 0;
            for(int i = 0; i < months; i++)
            {

                valorParcela = paypalService.Interest(contract.TotalValue/months, i+1);
                valorParcela = paypalService.PaymentFee(valorParcela);
                dataParcela = dataParcela.AddMonths(1);
                contract.Installments.Add(new Installment(dataParcela,valorParcela));
                valorParcela = 0;
            }
            Console.WriteLine("Installments:");
            foreach(Installment parcela in contract.Installments)
            {
                Console.WriteLine($"{parcela.DueDate.ToString("dd/MM/yyyy")} - {parcela.Amount}");
            }
        }
    }
}
