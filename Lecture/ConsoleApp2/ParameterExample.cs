using System;
namespace ConsoleApp2
{
    public class ParameterExample
    {

        /* Passing by Value(default)
         * Passing by Reference
         * Out mode parameters
         * Optional parameters
         * variable length parameter
         */
        public void PassingByValue(int a, int b) //formal parameters
        {
            a = 300;
            b = 1000;
        }

        public void PassingByReference(ref int a, ref int b) //formal parameters
        {
            a = 300;
            b = 1000;
        }

        //out mode
        public bool IsAuthenticated(string uname, string password, out string msg)
        {
            msg = "";
            bool flag = true;
            if (uname == "scott" && password == "tiger")
            {
                msg = "You are authenticated";
                return flag;

            }
            if (uname != "scott")
            {
                msg = "Invalid Username";
                flag = false;
                return flag;
            }
            if (password != "tiger")
            {
                msg = msg + "Invalid Password";
                flag = false;
                return flag;
            }
            return flag;
        }

        //optional
        public double CircleArea(double radius, double pi = 3.14)
        {
            return pi * radius * radius;
        }



        //Variable length parameter
        [Obsolete("Use AddNUmbers(params int[] args)", true)]
        public void AddTwoIntegers(int a, int b)
        {
            Console.WriteLine($"sum = {a + b}");
        }

        [Obsolete("Use AddNUmbers(params int[] args)", true)]
        public void AddThreeIntegers(int a, int b, int c)
        {
            Console.WriteLine($"sum = {a + b + c}");
        }

        public void AddNumbers(params int[] args)
        {
            int length = args.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = sum + args[i];
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}
