using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class ArithematicOperation : IArithematic
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine($"Sum ={a + b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication = {a * b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction ={a - b}");
        }
    }
}
