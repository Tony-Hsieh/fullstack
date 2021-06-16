using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //delegate:- it is a typesafe functionality which is used to pass a method as a parameter

            //ArithematicOperation arithematicOperation = new ArithematicOperation();
            //MathDelegate mathDelegate = new MathDelegate(arithematicOperation.Multiply);
            //int result = mathDelegate(30, 10);
            //Console.WriteLine(result);

            BuiltInDelegate builtInDelegate = new BuiltInDelegate();
            builtInDelegate.FuncExample();

        }
    }
}
