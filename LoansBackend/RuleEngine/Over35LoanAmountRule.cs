using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public class Over35LoanAmountRule : ILoanIntrestRule
    {
        public double CalculateLoanIntrest(LoanCreateDTO loanDTO, double primeRate, int _)
        {
            return loanDTO.Amount switch
            {
                <= 15000 => 1.5 + primeRate,
                > 5000 and <= 30000 => 3 + primeRate,
                _ => 1,
            };
        }
    }
}
