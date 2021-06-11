using System;
namespace ConsoleApp4
{
    class BaseCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public virtual void LogInformation()
        {
            Console.Write("Enter Id =>");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name =>");
            Name = Console.ReadLine();

            Console.Write("Enter Mobile =>");
            Mobile = Console.ReadLine();
        }
    }
    class Customer : BaseCustomer
    {
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public new void LogInformation()
        {
            base.LogInformation();
            Console.Write("Enter Bill Amount =>");
            TotalAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Discount =>");
            Discount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Bill Amount {TotalAmount - Discount}");
        }
    }
    class Visitor : BaseCustomer
    {
        public string ReasonNotToBuy { get; set; }
        public override void LogInformation()
        {
            base.LogInformation();

        }
    }
}
