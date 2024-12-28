using LoansBackend.Exceptions;
using LoansBackend.Models;
using LoansBackend.Repositories;

namespace LoansBackend.Services
{
    public class ClientService(IClientRepository clientRepository) : IClientService
    {
        private readonly IClientRepository _clientRepository = clientRepository;

        public Client GetClient(int id)
        {
            Client Client = this._clientRepository.GetById(id);

            return Client ?? throw new EntityNotFoundException($"Client with id {id} was not found");
        }
    }
}
