using System;
namespace ConsoleApp10
{
    public delegate int MathDelegate(int a, int b);
    public class ArithmaticOperation
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
