using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ExpenditureRepository: EfRepository<Expenditure>, IExpenditureRepository
    {
        public ExpenditureRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
        
        public async Task<Expenditure> DeleteAsync(int id)
        {
            var target= await _dbContext.Expenditures.SingleOrDefaultAsync(m => m.Id == id);
            if (target == null) {
                throw new Exception("target does not exist");
            }
            _dbContext.Expenditures.Remove(target);
            await _dbContext.SaveChangesAsync();
            return target;
        }

        public async Task<List<Expenditure>> GetExpenditureByUserId(int UserId)
        {
            var res=await _dbContext.Expenditures.Where(m => m.UserId == UserId).ToListAsync();
            return res;
        }
    }
}