using System;

namespace DapperTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageDept manageDept = new ManageDept();
            manageDept.Run();
            Console.WriteLine("Welcome");
            Console.Read();
            //ManageEmployee manageEmployee = new ManageEmployee();
            //manageEmployee.Run();
        }
    }
}
