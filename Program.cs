using System;
using System.Globalization;
using ex16.Entities;
using ex16.Services;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PayPalService());

            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments: ");
            Console.WriteLine(contract);
        }
    }
}
