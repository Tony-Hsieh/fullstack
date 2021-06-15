using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Dashboard
    {
        public static void Run()
        {
            Menu m = new Menu();
            int choice = (int)Options.Exit;
            CustomerFactory customerFactory = new CustomerFactory();
            do
            {
                Console.Clear();
                choice = m.Print(typeof(Options));
                BaseCustomer baseCustomer = customerFactory.GetObject(choice);
              if(baseCustomer != null)
                baseCustomer.LogInformation();

                Console.WriteLine("Press Enter to continue.....");
                Console.ReadLine();

            } while (choice != (int)Options.Exit);
        }
    }
}
