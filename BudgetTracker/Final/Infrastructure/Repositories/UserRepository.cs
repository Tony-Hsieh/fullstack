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
    public class UserRepository: EfRepository<User>, IUserRepository
    {
        public UserRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
        
        public async Task<User> GetUserById(int id)
        {
            var user = await _dbContext.Users.Include(u => u.Incomes)
                .Include(u => u.Expenditures)
                .FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }
        public async Task<User> GetUserByEmail(String email) {
            var user = await _dbContext.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
            return user;
        }

    }
}