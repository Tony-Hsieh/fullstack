using System;

namespace ConsoleApp3
{
    class BaseEmployee
    //if set to "sealed class BaseEmployee", this class cannot be inherited.
    {
        //property
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }
        public string EmailId { get; set; }

        protected void AddBaseEmployee()
        {
            Console.Write("Enter Id => ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name => ");
            Name = Console.ReadLine();

            Console.Write("Enter Department => ");
            DeptName = Console.ReadLine();

            Console.Write("Enter Email Id => ");
            EmailId = Console.ReadLine();
        }
    }
    class FullTimeEmployee : BaseEmployee
    {
        public decimal Salary { get; set; }
        public string Benefits { get; set; }

        public void AddFullTimeEmployee()
        {
            AddBaseEmployee(); //or base.AddBaseEmployee();

            Console.Write("Enter Salary => ");
            Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Benefits => ");
            Benefits = Console.ReadLine();
        }
    }
    class PartTimeEmployee : BaseEmployee
    {
        public decimal HourlyBilling { get; set; }
        public string Employer { get; set; }

        public void AddPartTimeEmployee()
        {
            base.AddBaseEmployee(); //or AddBaseEmployee();

            Console.Write("Enter Hourly Billing Rate => ");
            HourlyBilling = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Employer Name => ");
            Employer = Console.ReadLine();
        }
    }
}
