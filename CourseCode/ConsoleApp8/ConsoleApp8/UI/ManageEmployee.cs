using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp8.Model;
using ConsoleApp8.Repository;
namespace ConsoleApp8.UI
{
    class ManageEmployee
    {
        IRepository<Employee> empRepository;
        public ManageEmployee()
        {
            empRepository = new EmployeeRepository();
        }

        void AddEmployee()
        {
            Employee emp = new Employee();
            Console.Write("Enter Id =>");
            emp.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name => ");
            emp.Name = Console.ReadLine();
            Console.Write("Enter Salary => ");
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Department => ");
            emp.Department = Console.ReadLine();
            if (empRepository.Insert(emp) > 0)
                Console.WriteLine("Employee has been inserted");
            else
                Console.WriteLine("Some error has occured");
        }
        void PrintAllEmployee()
        {
            IEnumerable<Employee> collection = empRepository.GetAll();
            foreach (Employee item in collection)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Salary} \t {item.Department}");
            }
        }
        void DeleteEmployee()
        {
            Console.Write("Enter Id => ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (empRepository.Delete(id) > 0)
                Console.WriteLine("Employee deleted successfully");
            else
                Console.WriteLine("Employee not found");
        }
        void UpdateEmployee()
        {
            Employee emp = new Employee();
            Console.Write("Enter Id =>");
            emp.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name => ");
            emp.Name = Console.ReadLine();
            Console.Write("Enter Salary => ");
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Department => ");
            emp.Department = Console.ReadLine();
            if (empRepository.Update(emp) > 0)
                Console.WriteLine("Employee updated successfully");
            else
            {
                Console.WriteLine("Some error has occurred");
            }
        }

        public void Run()
        {
            int choice = 5;
            do
            {
                Console.Clear();
                Console.WriteLine("Press 1 to add Employee");
                Console.WriteLine("Press 2 to print Employee");
                Console.WriteLine("Press 3 to Delete Employee");
                Console.WriteLine("Press 4 to update Employee");
                Console.WriteLine("Press 5 to exit");
                Console.Write("Enter choice => ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        PrintAllEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for visit !!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue.....");
                Console.ReadLine();
            } while (choice != 5);
        }
    }
}
