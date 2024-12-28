namespace LoansBackend.Repositories
{
    public interface IDatastore<T>
    {
        IQueryable<T> Get();
        T Add(T Item);
    }
}
