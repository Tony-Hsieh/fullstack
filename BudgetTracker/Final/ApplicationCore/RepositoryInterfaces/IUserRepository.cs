using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IUserRepository: IAsyncRepository<User>
    {
        Task<User> GetUserById(int id);
        Task<User> GetUserByEmail(String email);
    }
}