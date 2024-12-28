using LoansBackend.DTOs;

namespace LoansBackend.Services
{
    public interface ILoanService
    {
        LoanDTO AddLoan(LoanCreateDTO loanDTO); 
    }
}
