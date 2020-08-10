namespace ex16.Services
{
    interface ITaxService
    {
        double Interest(double amount, int months);
        double Fee(double amount);
    }
}
