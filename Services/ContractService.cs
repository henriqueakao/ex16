using ex16.Entities;

namespace ex16.Services
{
    class ContractService
    {
        private ITaxService _taxService;

        public ContractService(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public void ProcessContract(Contract contract, int months)
        {

            for(int i = 1; i <= months; i++)
            {
                double amount = contract.TotalValue / months;
                amount += _taxService.Interest(amount, i);
                amount += _taxService.Fee(amount);

                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), amount));
            }
        }
    }
}
