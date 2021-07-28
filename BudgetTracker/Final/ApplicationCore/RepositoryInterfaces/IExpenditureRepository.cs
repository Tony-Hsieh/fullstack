using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IExpenditureRepository: IAsyncRepository<Expenditure>
    {
        public Task<Expenditure> DeleteAsync(int id);
        public Task<List<Expenditure>> GetExpenditureByUserId(int UserId);
    }
}