using System;

namespace ConsoleApp1
{

    /***  Casing Techniques: identifier
     *          1. Pascal casing: ex: ConsoleApp1
     *          2. Camel Casing: ex: string studentName
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //string studentName = "Tony Hs";
            //double gravity = 9.6;
            //float pi = 3.14f;

            //Console.WriteLine("Hello World!");
            //Console.WriteLine(studentName);
            //Console.WriteLine(gravity);
            //Console.WriteLine(pi);
            //AddNumbers();
            //Console.WriteLine(Multiply());

            //Program obj = new Program();

            //ManageEmployee manage = new ManageEmployee();
            //ManageEmployee.AddEmployee();

            //ManageDepartment dmanage = new ManageDepartment();
            //ManageDepartment.AddDepartment();

            Customer c1 = new Customer();
            Customer c2 = new Customer(1);
            Customer c3 = new Customer(2, "Simth");
            Customer c4 = new Customer(3, "J", "Newyork");

        }

        static void AddNumbers()
        {
            int a = 20, b = 30, c = 0;
            c = a + b;
            Console.WriteLine(c);

        }
        static int Multiply()
        {
            int a = 20, b = 10, c = 0;
            c = a * b;
            return c;
        }
    }
}
