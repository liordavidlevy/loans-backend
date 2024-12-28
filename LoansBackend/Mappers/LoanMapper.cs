using LoansBackend.DTOs;
using LoansBackend.Models;

namespace LoansBackend.Mappers
{
    public class LoanMapper
    {
        public LoanDTO ToLoanDTO(Loan loan)
        {
            LoanDTO LoanDTO = new()
            {
                Id = loan.Id,
                ClientId = loan.ClientId,
                Amount = loan.Amount
            };

            return LoanDTO;
        }
    }
}
