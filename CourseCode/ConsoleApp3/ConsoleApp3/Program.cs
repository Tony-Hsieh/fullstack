using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            int option = 3;
            Console.Title = "Inheritance Example";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            do
            {
                Console.Clear();
                option = m.Print();
                switch (option) {
                    case (int)Options.FullTimeEmployee:
                        FullTimeEmployee fte = new FullTimeEmployee();
                        fte.AddFullTimeEmployee();
                        break;
                    case (int)Options.PartTimeEmployee:
                        PartTimeEmployee pte = new PartTimeEmployee();
                        pte.AddPartTimeEmployee();
                        break;
                    case (int)Options.Exit:
                        Console.WriteLine("Thanks for Visit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option !!!!!");
                        break;
                }

                Console.WriteLine("Press Enter to Continue.......");
                Console.ReadLine();


            } while (option != (int)Options.Exit);

           
        }
    }
}
