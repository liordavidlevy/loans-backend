using LoansBackend.DTOs;
using LoansBackend.Mappers;
using LoansBackend.Models;
using LoansBackend.Repositories;

namespace LoansBackend.Services
{
    public class LoanService(LoanFactory loanFactory, LoanMapper loanMapper, ILoanRepository loanRepository, IClientService clientService) : ILoanService
    {
        private static readonly double _primeIntrest = 1.5;

        private readonly LoanFactory _loanFactory = loanFactory;
        private readonly LoanMapper _loanMapper = loanMapper;
        private readonly ILoanRepository _loanRepository = loanRepository;
        private readonly IClientService _clientService = clientService;

        public LoanDTO AddLoan(LoanCreateDTO loanDTO)
        {
            Client client = this._clientService.GetClient(loanDTO.ClientId);
            double intrest = 0; 

            if (client.Age < 20)
            {
                intrest = 2 + _primeIntrest;
            }

            Loan Loan = this._loanFactory.CreateLoan(client.Id, loanDTO.Amount + loanDTO.Amount * intrest, loanDTO.Period);

            return this._loanMapper.ToLoanDTO(this._loanRepository.Add(Loan));
        }
    }
}
