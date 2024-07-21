namespace CleanArchitectureApp.Application.Interfaces.Persistence
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(string id);
        Task<ICollection<T>> GetListAsync(string accountId);
        Task<T> AddAsync(T item);
    }
}
