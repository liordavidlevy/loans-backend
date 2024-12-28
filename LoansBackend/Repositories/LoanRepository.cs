using LoansBackend.Models;
using LoansBackend.Utils;

namespace LoansBackend.Repositories
{
    public class LoanRepository(SequenceGenerator generator) : ILoanRepository
    {
        private readonly IDatastore<Loan> _datastore = new JsonDatastore<Loan>("loans.json"); 
        private readonly SequenceGenerator _generator = generator;

        public Loan Add(Loan loan)
        {
            loan.Id = this._generator.GenerateId();

            return this._datastore.Add(loan);
        }
    }
}
