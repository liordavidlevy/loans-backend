using LoansBackend.Models;

namespace LoansBackend.Services
{
    public interface IClientService
    {
        Client GetClient(int id);
    }
}
