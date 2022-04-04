using InterfaceCSharpChallange.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharpChallange.Services
{
    internal class ServicePayment
    {

        public void ProcessPayment(Contract contract, int installments, ITaxService taxService)
        {
            double amount = contract.TotalValue / installments;
            double month = 1.0;
            for (int i = 0; i < installments; i++)
            {
                
                DateTime dateTime = contract.Date;
                dateTime = dateTime.AddMonths(i);
                double quota = amount;
                quota = quota + (taxService.SimpleTax(amount) * month);
                quota = quota + taxService.Tax(quota);
                month ++;
                

                contract.installments.Add(new Installment(dateTime, quota));
            }




        }
    }
}
