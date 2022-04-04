namespace InterfaceCSharpChallange.Services
{
    internal class Paypal : ITaxService
    {
        public double SimpleTax(double amount)
        {
            return amount * 0.01;
        }

        public double Tax(double amount)
        {
            return amount * 0.02;
        }
    }
}
