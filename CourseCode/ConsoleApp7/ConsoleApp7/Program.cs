using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            IArithematic arithematic = new ArithematicOperation();
            arithematic.Addition(20, 10);
            arithematic.Subtract(30, 12);
            arithematic.Multiply(29, 17);
        }
    }
}
