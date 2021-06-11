using System;
using ConsoleApp1.Model;

namespace ConsoleApp1
{
    public class ManageEmployee
    {
        public ManageEmployee()
        {
        }

        public static void AddEmployee()
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.FullName = "Will Smith";
            emp.Mobile = "9876543210";
            emp.Salary = 7000;
            emp.DeptId = 3;
            Console.WriteLine($"{emp.Id} \t {emp.FullName} \t {emp.Mobile} \t {emp.Salary} \t {emp.DeptId}");
        }
    }
}
