using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharpChallange.Entities
{
    internal class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
