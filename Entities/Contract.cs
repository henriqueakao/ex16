using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace ex16.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Installment inst in Installments)
            {
                sb.AppendLine(inst.DueDate.ToString("dd/MM/yyyy") + " - " + inst.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
