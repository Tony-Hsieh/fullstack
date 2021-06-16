using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp11.Model;
using ConsoleApp11.Repository;
namespace ConsoleApp11.UI
{
    class ManageCustomer
    {
        CustomerRepository customerRepository;
        public ManageCustomer()
        {
            customerRepository = new CustomerRepository();
        }

        public void PrintCustomers()
        {
            // IEnumerable<Customer> collection = customerRepository.GetDataBySearch((c) => c.Country == "UK" && c.City == "Wales");
            IEnumerable<Customer> collection = customerRepository.GetDataBySearch(x => x.Id == 3);
            foreach (Customer item in collection)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.City} \t {item.Country}");
            }
        }


    }
}
