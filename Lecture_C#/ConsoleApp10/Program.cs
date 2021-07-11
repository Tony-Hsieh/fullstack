using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            //delegate: it is a typesafe functionality which is used to pass a method as a parameter

            //ArithmaticOperation arithmaticOperation = new ArithmaticOperation();
            //MathDelegate mathDelegate = new MathDelegate(arithmaticOperation.Multiply);
            //int result = mathDelegate(30, 10);
            //Console.WriteLine(result);

            BuiltInDelegate builtInDelegate = new BuiltInDelegate();
            builtInDelegate.ActionExample();

            builtInDelegate.PredicateExample();

            builtInDelegate.FuncExample();
        }
    }
}
