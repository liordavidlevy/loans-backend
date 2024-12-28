using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public class PeriodLoanInterstRule : ILoanIntrestRule
    {
        public double CalculateLoanIntrest(LoanCreateDTO loanDTO, double _, int __)
        {
            if (loanDTO.Period <= 12)
            {
                return 0;
            }

            return (loanDTO.Period - 12) * 0.15;
        }
    }
}
