using CleanArchitectureApp.Application.Interfaces.Persistence;
using CleanArchitectureApp.Domain.Entities;

namespace CleanArchitectureApp.Infrastructure.Repositories
{
    public class FormRepository : IRepository<Form>
    {
        public Task<Form> AddAsync(Form item)
        {
            throw new NotImplementedException();
        }

        public Task<Form> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Form>> GetListAsync(string accountId)
        {
            throw new NotImplementedException();
        }
    }
}
