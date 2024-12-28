namespace LoansBackend.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public double Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
