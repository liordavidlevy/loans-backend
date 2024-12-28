namespace LoansBackend.DTOs
{
    public class LoanCreateDTO
    {
        public int ClientId { get; set; }
        public int Amount { get; set; }
        public int Period { get; set; }
    }
}
