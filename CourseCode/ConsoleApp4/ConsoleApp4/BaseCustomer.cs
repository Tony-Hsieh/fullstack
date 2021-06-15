using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    /*
     *  abstract methods are by default virtual and must be overriden in the derived type
     *  abstract methods are just declared in base class and implemented in the derived type
     *  if there is one abstract method then the whole class must be abstract
     *  abstract class is always a base class and must be implemented by derived type
     *  abstract class can have both abstract and non-abstract methods
     *  abstract class can have constructor but you can not call this constructor to create an object.
     *  abstract class can not be instantiated.
     *  abstract class can have variables
     *  abstract class supports only single inheritance
     */
  abstract  class BaseCustomer
    {
        public BaseCustomer()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public abstract void LogInformation();

        public void Welcome() {
            Console.WriteLine("This is welcome method");
        }

    }
    class Customer : BaseCustomer
    {
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public override void LogInformation()
        {
            Console.Write("Enter Id => ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name => ");
            Name = Console.ReadLine();

            Console.Write("Enter Mobile => ");
            Mobile = Console.ReadLine();
            Console.Write("Enter Bill Amount => ");
            TotalAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Discount => ");
            Discount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Bill Amount {TotalAmount - Discount}");
        }
    }
    class Visitor : BaseCustomer
    {
        public string ReasonNotToBuy { get; set; }
        public  override void LogInformation()
        {
            Console.Write("Enter Id => ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name => ");
            Name = Console.ReadLine();

            Console.Write("Enter Mobile => ");
            Mobile = Console.ReadLine();
            Console.Write("Enter Reason => ");
            ReasonNotToBuy = Console.ReadLine();
        }
    }
}
