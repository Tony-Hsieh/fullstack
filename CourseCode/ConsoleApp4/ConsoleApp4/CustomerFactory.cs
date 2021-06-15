using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class CustomerFactory
    {
        public BaseCustomer GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.Customer:
                    return new Customer();  //anonymous object
                case (int)Options.Vistior:
                    return new Visitor();
                default:
                    return null;

            }
        }
    }
}
