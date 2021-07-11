using System;
using System.Collections.Generic;
using System.Text;
using Antra.DapperTraining.Data.Models;
using Antra.Dapper.Data.Repository;
namespace DapperTraining
{
    class ManageDept
    {
        IRepository<Dept> deptRepository;
        IRepositoryAsync<Dept> deptRepositoryAsync;
        public ManageDept()
        {
            deptRepository = new DeptRepository();
            deptRepositoryAsync = new DeptRepository();
        }
        void PrintAll()
        {
            var collection = deptRepository.GetAll();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.Id + "\t" + item.DName + "\t" + item.Loc);
                }
            }
        }

        async void PrintAllAsync()
        {
            var collection = await deptRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.Id + "\t" + item.DName + "\t" + item.Loc);
                }
            }
        }

        public void Run()
        {
            PrintAllAsync();
        }
    }
}
