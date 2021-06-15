using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Menu
    {
        public int Print()
        {
            string[] names = Enum.GetNames(typeof(Options));
            int[] values = (int[])Enum.GetValues(typeof(Options));
            int length = names.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Press {values[i]} for {names[i]}");
            }

            Console.Write("Enter your choice => ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
