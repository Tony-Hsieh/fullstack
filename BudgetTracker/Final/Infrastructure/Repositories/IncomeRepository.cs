using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class IncomeRepository: EfRepository<Income>, IIncomeRepository
    {
        public IncomeRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Income>> GetIncomeByUserId(int UserId)
        {
            var res=await _dbContext.Incomes.Where(m => m.UserId == UserId).ToListAsync();
            return res;
        }
    }
}