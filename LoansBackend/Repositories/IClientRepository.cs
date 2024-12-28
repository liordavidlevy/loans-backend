using LoansBackend.Models;

namespace LoansBackend.Repositories
{
    public interface IClientRepository
    {
        Client GetById(int id);
    }
}
