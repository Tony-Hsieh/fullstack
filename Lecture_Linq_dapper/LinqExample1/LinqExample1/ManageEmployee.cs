using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LinqExample1
{
    class ManageEmployee
    {
        EmployeeRepository employeeRepository;
        public ManageEmployee()
        {
            employeeRepository = new EmployeeRepository();
        }

        void WhereExample()
        {
            var result = employeeRepository.GetAll().Where(x => x.City == "Chicago");
            foreach (var item in result)
            {
                Console.WriteLine(item.Id + " \t " + item.FirstName + " \t " + item.City);
            }
        }

        void SelectExample()
        {
            var result = employeeRepository.GetAll().Select(x => new { x.Id, x.FirstName, x.City });
            foreach (var item in result)
            {
                Console.WriteLine(item.Id + " \t " + item.FirstName + " \t " + item.City);
            }
        }

        public void Run()
        {
            SelectExample();
        }
    }
}
