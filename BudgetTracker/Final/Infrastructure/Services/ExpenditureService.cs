using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class ExpenditureService: IExpenditureService
    {
        private readonly IExpenditureRepository _expenditureRepository;
        public ExpenditureService(IExpenditureRepository ExpenditureRepository) {
            _expenditureRepository = ExpenditureRepository;
        }
        
        public async Task<string> AddExpenditure(ExpenditureRequestModel request) {
            request.ExpDate = DateTime.Now;
            var expenditure = new Expenditure() {
                Amount = request.Amount, Description = request.Description,
                ExpDate = DateTime.Now, Remarks = request.Remarks,
                UserId = request.UserId
            };
            await _expenditureRepository.AddAsync(expenditure);
            return "Done";
        }
        public async Task<string> UpdateExpenditure(ExpenditureRequestModel request) {
            var target=await _expenditureRepository.GetByIdAsync(request.Id);
            if (target == null) {
                throw new Exception("target does not exist");
            }
            target.Amount = (decimal) (request.Amount==0? target.Amount: request.Amount);
            target.Description = request.Description==null? target.Description: request.Description;
            target.ExpDate = request.ExpDate==null? target.ExpDate: request.ExpDate;
            target.Remarks = request.Remarks==null? target.Remarks:request.Remarks;
            target.UserId = request.UserId==null?target.UserId: request.UserId;
            await _expenditureRepository.UpdateAsync(target);
            return "target";
        }
        
        public async Task<string> DeleteExpenditure(ExpenditureRequestModel request)
        {
            await _expenditureRepository.DeleteAsync(request.Id);
            return "done";
        }

        public async Task<List<ExpenditureResponseModel>> ListAllExpenditures() {
            var Expenditures= await _expenditureRepository.ListAllAsync();
            var res = new List<ExpenditureResponseModel>();
            foreach (var expenditure in Expenditures) {
                var temp = new ExpenditureResponseModel()
                {
                    Amount = expenditure.Amount,
                    Description = expenditure.Description,
                    ExpDate = expenditure.ExpDate,
                    Id = expenditure.Id,
                    Remarks = expenditure.Remarks,
                    UserId = expenditure.UserId
                };
                res.Add(temp);
            }
            return res;
        }
    }
}