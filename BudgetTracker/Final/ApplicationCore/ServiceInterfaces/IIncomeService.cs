using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IIncomeService
    {
        Task<String> AddIncome(IncomeRequestModel incomeRequest);
        Task<String> UpdateIncome(IncomeRequestModel incomeRequest);
        Task<String> DeleteIncome(IncomeRequestModel incomeRequestModel);
        Task<List<IncomeResponseModel>> ListAllIncomes();
    }
}