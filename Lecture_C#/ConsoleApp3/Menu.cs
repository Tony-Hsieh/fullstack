using System;
namespace ConsoleApp3
{
    class Menu
    {
        public int Print()
        {
            Console.WriteLine("Press 1 for Full Time Employee");
            Console.WriteLine("Press 2 for Part Time Employee");
            Console.WriteLine("Press 3 for Exit");

            string[] names = Enum.GetNames(typeof(Options));
            int[] values = (int[])Enum.GetValues(typeof(Options));


            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }
    }
}
