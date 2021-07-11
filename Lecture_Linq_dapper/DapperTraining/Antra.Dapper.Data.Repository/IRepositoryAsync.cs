using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Antra.Dapper.Data.Repository
{
   public interface IRepositoryAsync<T> where T : class
    {
        Task<int> InsertAsync(T obj);
        Task<int> UpdateAsync(T obj);
        Task<int> DeleteAsync(T obj);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}
