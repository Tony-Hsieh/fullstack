using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterExample parameterExample = new ParameterExample();

            //Pass by value and reference
            //int x = 20, y = 30;
            //Console.WriteLine($"before passing x={x} and y={y}");
            //parameterExample.PassingByValue(x, y);
            //Console.WriteLine($"after passing x={x} and y={y}");

            //Console.WriteLine($"before passing x={x} and y={y}");
            //parameterExample.PassingByReference(ref x, ref y);
            //Console.WriteLine($"after passing x={x} and y={y}");


            //Out mode parameter
            string str;
            bool flag = parameterExample.IsAuthenticated("scott", "tiger", out str);
            Console.WriteLine(str);

            //optional parameter
            double area = parameterExample.CircleArea(10);
            Console.WriteLine($"Area of circle = {area} ");

            //variable length parameter
            parameterExample.AddNumbers(20, 30, 40);
            parameterExample.AddTwoIntegers(10, 20);
        }
    }
}
