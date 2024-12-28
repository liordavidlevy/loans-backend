using LoansBackend.Models;

namespace LoansBackend.Repositories
{
    public interface ILoanRepository
    {
        Loan Add(Loan loan);
    }
}
