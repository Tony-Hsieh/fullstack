﻿using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.GetData();
            r.Display();
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        // member variables
        double length = 1;
        double width = 1;

        public void GetData()
        {
            again:
            Console.WriteLine("enter length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width:");
            width = Convert.ToInt32(Console.ReadLine());
            if (length < 0 || length > 20 || width < 0 || width > 20)
            {
                Console.WriteLine("please enter length and width between 0 and 20");
                goto again;
            }
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
        public void Display()
        {
            Console.WriteLine($"Area of Rectangle: {GetArea()}");
            Console.WriteLine($"Perimeter of Rectangle: {GetPerimeter()}");
        }

    }
}
