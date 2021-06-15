using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ManageCustomer
    {
        List<Customer> customerCollection = new List<Customer> {
        new Customer(){ Id=1, Name="Smith", City="Sterling"},
        new Customer(){ Id=2, Name="Daniel",City="Chicago"},
        new Customer(){ Id=3, Name="John",City="Dulles"}
        };

        void InsertCustomer()
        {
            Customer c = new Customer();
            Console.Write("Enter Id = ");
            c.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name = ");
            c.Name = Console.ReadLine();

            Console.Write("Enter City = ");
            c.City = Console.ReadLine();

            customerCollection.Add(c);
        }

        void Print()
        {
            foreach (Customer item in customerCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.City);
            }

        }

        void Delete()
        {

            Console.Write("Enetr Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Customer c = new Customer();
            foreach (Customer item in customerCollection)
            {
                if (item.Id == id)
                {
                    c = item;
                    break;
                }
            }
            customerCollection.Remove(c);

        }
        public void Run()
        {
            InsertCustomer();
            Delete();
            Print();
        }
    }


}
