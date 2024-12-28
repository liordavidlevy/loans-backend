using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public class AgeLoanIntrestRule : ILoanIntrestRule
    {
        private readonly ILoanIntrestRule _below20 = new Under20LoanAmountRule();
        private readonly ILoanIntrestRule _between20And35 = new Between20And35LoanAmountRule();
        private readonly ILoanIntrestRule _over35 = new Over35LoanAmountRule();

        public double CalculateLoanIntrest(LoanCreateDTO loanDTO, double primeRate, int age)
        {
            ILoanIntrestRule rule = age switch
            {
                < 20 => this._below20,
                >= 20 and <= 35 => this._between20And35,
                _ => this._over35
            };

            return rule.CalculateLoanIntrest(loanDTO, primeRate, age);
        }
    }
}
