using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Exceptions;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using AutoMapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IIncomeRepository _incomeRepository;
        private readonly IExpenditureRepository _expenditureRepository;
        
        public UserService(IUserRepository userRepository, IIncomeRepository incomeRepository, IExpenditureRepository expenditureRepository)
        {
            _userRepository = userRepository;
            _incomeRepository = incomeRepository;
            _expenditureRepository = expenditureRepository;
            
        }
        public async Task<string> DeleteUser(UserRequestModel request)
        {
            var target = await _userRepository.GetByIdAsync(request.Id);
            await _userRepository.DeleteAsync(target);
            return "Done";
        }
        
        public async Task<List<UserResponseModel>> ListAllUsers()
        {
            var users = await _userRepository.ListAllAsync();
            var usersList = new List<UserResponseModel>();
            foreach (var user in users)
            {
                usersList.Add(new UserResponseModel
                    {Id = user.Id, FullName = user.FullName});
            }
            return usersList;
        }
        public async Task<UserDetailsResponseModel> GetUserDetailById(int id)
        {
            var expenditures = await _expenditureRepository.GetExpenditureByUserId(id);
            var incomes = await _incomeRepository.GetIncomeByUserId(id);
            var user = await _userRepository.GetByIdAsync(id);
            
            if (user == null) throw new NotFoundException("User", id);

            var userDetail = new UserDetailsResponseModel()
            {
                UserId = user.Id, FullName = user.FullName,
                Expenditures = expenditures, Incomes = incomes,
            };
            return userDetail;
        }
        public async Task<String> RegisterUser(UserRequestModel request) {
            var check = await _userRepository.GetUserByEmail(request.Email);
            if (check != null) {
                throw new Exception("Email already exist try another one");
            }
            var salt = CreateSalt();
            var pw = HashPassword(request.Password, salt);
            User user = new User { 
                Email=request.Email,FullName=request.Fullname,Password=pw,JoinedOn=DateTime.Now,Salt=salt};
            await _userRepository.AddAsync(user);
            return "successed";
        }
        
        public async Task<UserResponseModel> Login(UserRequestModel request)
        {
            var User = await _userRepository.GetUserByEmail(request.Email);
            if (User == null)
            {
                return null;
            }
            var pw = HashPassword(request.Password, User.Salt);
            if (User.Password!=pw) {
                return null;
            }
            var response = new UserResponseModel()
            {
                Email = User.Email,
                FullName = User.FullName,
                Id = User.Id,
                JoinedOn = User.JoinedOn
            };
            return response;
        }

        private string CreateSalt()
        {
            byte[] randomBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            return Convert.ToBase64String(randomBytes);
        }
        
        private string HashPassword(string password, string salt)
        {
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }



        public async Task<string> UpdateUser(UserRequestModel request)
        {
            var target =await _userRepository.GetUserByEmail(request.Email);
            if (target.Email != request.Email && request.Email != null) {
                var check =await _userRepository.GetUserByEmail(request.Email);
                if (check != null) {
                    throw new Exception("email already exist change one");
                }
            }
            if (target == null) {
                throw new Exception("target does not exist");
            }
            target.Email = request.Email == null ? target.Email : request.Email;
            target.FullName = request.Fullname==null? target.FullName : request.Fullname;
            target.JoinedOn = request.JoinOn==null?target.JoinedOn:request.JoinOn;
            if (request.Password != null) {
                if (HashPassword(request.Password, target.Salt) != target.Password) {
                    var salt = CreateSalt();
                    var newpw = HashPassword(request.Password, salt);
                    target.Salt = salt;
                    target.Password = newpw;
                }
            }
            await _userRepository.UpdateAsync(target);
            return "successed";
        }
    }

    
}