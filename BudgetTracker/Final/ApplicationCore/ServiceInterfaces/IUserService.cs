using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<string> RegisterUser(UserRequestModel request);
        Task<string> UpdateUser(UserRequestModel request);
        Task<string> DeleteUser(UserRequestModel request);
        Task<List<UserResponseModel>> ListAllUsers();
        Task<UserResponseModel> Login(UserRequestModel request);
        Task<UserDetailsResponseModel> GetUserDetailById(int id);
        

    }

   
}