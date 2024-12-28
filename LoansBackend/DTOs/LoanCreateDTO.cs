using System.ComponentModel.DataAnnotations;

namespace LoansBackend.DTOs
{
    public class LoanCreateDTO
    {
        [Range(1, int.MaxValue)]
        public int ClientId { get; set; }

        [Range(1, int.MaxValue)]
        public int Amount { get; set; }

        [Range(12, int.MaxValue)]
        public int Period { get; set; }
    }
}
