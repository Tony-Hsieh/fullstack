using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IIncomeRepository: IAsyncRepository<Income>
    {
        public Task<List<Income>> GetIncomeByUserId(int UserId);
    }
}