using System;
using ConsoleApp11.UI;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            manageCustomer.PrintCustomers();
        }
    }
}
