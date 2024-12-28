using LoansBackend.DTOs;
using LoansBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoansBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController(ILoanService loanService) : ControllerBase
    {
        private readonly ILoanService _loanService = loanService;

        [HttpPost(Name = "AddLoan")]
        public LoanDTO AddLoan([FromBody] LoanCreateDTO loanDTO)
        {
            return this._loanService.AddLoan(loanDTO);
        }
    }
}
