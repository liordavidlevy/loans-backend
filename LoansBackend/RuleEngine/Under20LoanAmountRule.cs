using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public class Under20LoanAmountRule : ILoanIntrestRule
    {
        public double CalculateLoanIntrest(LoanCreateDTO _, double primeRate, int __)
        {
            return primeRate + 2;
        }
    }
}
