using LoansBackend.Models;

namespace LoansBackend.Mappers
{
    public class LoanFactory
    {
        public Loan CreateLoan(int clientId, double amount, int period)
        {
            Loan Loan = new();
            DateTime StartDate = DateTime.Now;

            Loan.ClientId = clientId;
            Loan.Amount = amount;
            Loan.StartDate = StartDate;
            Loan.EndDate = StartDate.AddMonths(period);

            return Loan;
        }
    }
}
