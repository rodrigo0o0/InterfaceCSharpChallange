using InterfaceCSharpChallange.Entities;
using InterfaceCSharpChallange.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharpChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number : "); 
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy) : ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value : ");
            double contractValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments : ");
            int installments = int.Parse(Console.ReadLine());
            Contract contract = new Contract(number,dateTime, contractValue);
            ServicePayment servicePayment = new ServicePayment();
            servicePayment.ProcessPayment(contract, installments, new Paypal());
            Console.WriteLine("INSTALLMENTS : ");
            foreach (var item  in contract.installments)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
