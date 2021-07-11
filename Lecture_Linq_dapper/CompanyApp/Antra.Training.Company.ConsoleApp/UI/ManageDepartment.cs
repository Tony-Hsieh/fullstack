using System;
using System.Collections.Generic;
using System.Text;
using Antra.Training.Company.Data.Models;
using Antra.Training.Company.Data.Repositories;
namespace Antra.Training.Company.ConsoleApp.UI
{
    class ManageDepartment
    {
        IRepository<Dept> deptRepository;
        public ManageDepartment()
        {
            deptRepository = new DeptRepository();
        }

        void AddDepartment()
        {
            Dept d = new Dept();
            Console.Write("Enter Name => ");
            d.DName = Console.ReadLine();
            Console.Write("Enter Location => ");
            d.Loc = Console.ReadLine();
           if( deptRepository.Insert(d)>0)
                Console.WriteLine("Department added successfully");
           else
                Console.WriteLine("Some error has occured");
        }

        void PrintAll()
        {
            var collection = deptRepository.GetAll();
            foreach (var item in collection)
            {
                Console.WriteLine(item.Id +" \t "+item.DName+" \t "+item.Loc);
            }
        }
        public void Run()
        {
            PrintAll();
        }
    }
}
