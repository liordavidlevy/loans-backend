using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public class Between20And35LoanAmountRule : ILoanIntrestRule
    {
        public double CalculateLoanIntrest(LoanCreateDTO loanDTO, double primeRate, int _)
        {
            return loanDTO.Amount switch
            {
                <= 5000 => 2,
                > 5000 and <= 30000 => 1.5 + primeRate,
                _ => 1 + primeRate,
            };
        }
    }
}
