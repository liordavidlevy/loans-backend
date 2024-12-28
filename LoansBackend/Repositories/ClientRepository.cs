using LoansBackend.Models;

namespace LoansBackend.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDatastore<Client> _datastore;

        public ClientRepository()
        {
            this._datastore = new JsonDatastore<Client>("clients.json");
        }

        public Client GetById(int Id)
        {
            return this._datastore.Get().First(client => client.Id == Id);
        }
    }
}
