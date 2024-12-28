using LoansBackend.DTOs;

namespace LoansBackend.RuleEngine
{
    public class LoanIntrestRuleEngine
    {
        private static readonly double PRIME_INTREST = 1.5;

        private readonly IList<ILoanIntrestRule> _intrestRules;

        public LoanIntrestRuleEngine()
        {
            this._intrestRules = new List<ILoanIntrestRule>
            {
                new PeriodLoanInterstRule(),
                new AgeLoanIntrestRule()
            };
        }

        public double CalculateLoanIntrest(LoanCreateDTO loanDTO, int age)
        {
            return this._intrestRules.Sum(rule => rule.CalculateLoanIntrest(loanDTO, PRIME_INTREST, age));
        }
    }
}
