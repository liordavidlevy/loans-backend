using LoansBackend.Exceptions;
using LoansBackend.Models;
using LoansBackend.Repositories;

namespace LoansBackend.Services
{
    public class ClientService(IClientRepository clientRepository, ILogger<Client> logger) : IClientService
    {
        private readonly IClientRepository _clientRepository = clientRepository;
        private readonly ILogger<Client> _logger = logger;

        public Client GetClient(int id)
        {
            try
            {
                return this._clientRepository.GetById(id);
            } catch (InvalidOperationException exception)
            {
                this._logger.LogWarning(exception.Message);
                throw new EntityNotFoundException($"Client with id {id} was not found");
            }
        }
    }
}
