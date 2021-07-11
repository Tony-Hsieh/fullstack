using System;
using System.Collections.Generic;
using System.Text;
using Antra.Dapper.Data.Repository;
using Antra.DapperTraining.Data.Models;
namespace DapperTraining
{
    class ManageEmployee
    {
        IRepository<Employee> empRepository;
        public ManageEmployee()
        {
            empRepository = new EmployeeRepository();
        }

        void PrintAll()
        {
            var collection = empRepository.GetAll();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.Id + "\t" + item.EName + "\t" + item.Dept.DName);
                }
            }
        }

        public void Run()
        {
            PrintAll();
        }
    }
}
