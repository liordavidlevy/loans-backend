using System.Net;
using System.Web.Http;
using LoansBackend.DTOs;
using LoansBackend.Exceptions;
using LoansBackend.Mappers;
using LoansBackend.Models;
using LoansBackend.Repositories;
using LoansBackend.RuleEngine;

namespace LoansBackend.Services
{
    public class LoanService(LoanFactory loanFactory, LoanMapper loanMapper, LoanIntrestRuleEngine loanIntrestRuleEngine, ILoanRepository loanRepository, IClientService clientService) : ILoanService
    {
        private readonly LoanFactory _loanFactory = loanFactory;
        private readonly LoanMapper _loanMapper = loanMapper;
        private readonly LoanIntrestRuleEngine _loanIntrestRuleEngine = loanIntrestRuleEngine;
        private readonly ILoanRepository _loanRepository = loanRepository;
        private readonly IClientService _clientService = clientService;

        public LoanDTO AddLoan(LoanCreateDTO loanDTO)
        {
            Client client = this._clientService.GetClient(loanDTO.ClientId);
            double intrest = this._loanIntrestRuleEngine.CalculateLoanIntrest(loanDTO, client.Age);
            double loanAmount = ((intrest / 100) + 1) * loanDTO.Amount;

            Loan Loan = this._loanFactory.CreateLoan(client.Id, loanAmount, loanDTO.Period);

            return this._loanMapper.ToLoanDTO(this._loanRepository.Add(Loan));
        }
    }
}
