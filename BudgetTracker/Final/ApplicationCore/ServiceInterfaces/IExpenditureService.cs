using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IExpenditureService
    {
        Task<string> AddExpenditure(ExpenditureRequestModel expenditureRequest);
        Task<string> DeleteExpenditure(ExpenditureRequestModel expenditureRequest);
        Task<string> UpdateExpenditure(ExpenditureRequestModel expenditureRequest);
        Task<List<ExpenditureResponseModel>> ListAllExpenditures();
       
    }
}