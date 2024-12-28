using Newtonsoft.Json;

namespace LoansBackend.Repositories
{
    public class JsonDatastore<T>(string dataFile) : IDatastore<T>
    {
        private readonly string _dataFile = dataFile;
        private readonly IList<T> _data = JsonConvert.DeserializeObject<IList<T>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, dataFile)));

        public IQueryable<T> Get()
        {
            return this._data.AsQueryable();
        }

        public T Add(T item)
        {
            lock (this)
            {
                this._data.Add(item);
                string Json = JsonConvert.SerializeObject(this._data);
                File.WriteAllText(this._dataFile, Json);

                return item;
            }
        }
    }
}
