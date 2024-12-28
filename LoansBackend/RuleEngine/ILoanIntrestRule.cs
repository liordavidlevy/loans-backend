using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public interface ILoanIntrestRule
    {
        double CalculateLoanIntrest(LoanCreateDTO loanDTO, double primeRate, int age);
    }
}
