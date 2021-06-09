using System;
using ConsoleApp1.Model;
namespace ConsoleApp1
{
    public class ManageDepartment
    {
        public ManageDepartment()
        {
        }
        public static void AddDepartment()
        {
            Department department = new Department();
            Console.Write("Enter Id");
            department.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name");
            department.DName = Console.ReadLine();
            Console.Write("Enter Location");
            department.Location = Console.ReadLine();

        }
    }
}
