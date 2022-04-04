using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharpChallange.Services
{
    internal interface ITaxService
    {
        double SimpleTax(double amount);
        double Tax(double amount);


    }
}
