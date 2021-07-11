using System;
using Antra.Training.Company.ConsoleApp.UI;
namespace Antra.Training.Company.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageDepartment manageDepartment = new ManageDepartment();
            manageDepartment.Run();
        }
    }
}
