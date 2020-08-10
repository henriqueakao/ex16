namespace ex16.Services
{
    class PayPalService : ITaxService
    {
        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

        public double Fee(double amount)
        {
            return amount * 0.02;
        }
    }
}
