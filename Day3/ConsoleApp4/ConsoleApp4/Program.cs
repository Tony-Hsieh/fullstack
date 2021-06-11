using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomer baseCustomer = new BaseCustomer();
            //baseCustomer.LogInformation(); // base class method // method hiding

            BaseCustomer baseCustomer1 = new Visitor();
            baseCustomer1.LogInformation(); // derived class method // overriding method
        }
    }
}
