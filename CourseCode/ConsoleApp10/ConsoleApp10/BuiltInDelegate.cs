using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class BuiltInDelegate
    {
        /*
         * Action :- action can take any generic input parameter but returns void
         * Predicate :- it can take any generic input and returns bool value
         * Func :- it can take any generic input value and return any generic output.
         
         */

        public void ActionExample()
        {
            //Action<int> primeNumber = new Action<int>(CheckPrime);
            Action<int> primeNumber = delegate (int number)
            {     //anonymous method
                bool flag = true;
                if (number > 0 && number < 4)
                    flag = true;
                else
                {
                    for (int i = 2; i < number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            flag = false;
                            break;
                        }

                    }
                }
                if (flag)
                    Console.WriteLine("Prime number");
                else
                    Console.WriteLine("Not prime number");
            };
            primeNumber(37);

            // Action<string> palindrome = new Action<string>(CheckPalindrome);
            Action<string> palindrome = delegate (string input)
            {

                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("Empty string ");
                else
                {
                    int length = input.Length;
                    int j = length - 1;
                    bool flag = true;
                    for (int i = 0; i < length / 2; i++)
                    {
                        if (input[i] != input[j])
                        {
                            flag = false;
                            break;
                        }
                        j--;
                    }
                    if (flag)
                        Console.WriteLine("Palindrome string");
                    else
                        Console.WriteLine("Not a palindrome string");
                }

            };
            palindrome("madxam");
        }
        //void CheckPrime(int number)
        //{
        //    bool flag = true;
        //    if (number > 0 && number < 4)
        //        flag = true;
        //    else
        //    {
        //        for (int i = 2; i < number / 2; i++)
        //        {
        //            if (number % i == 0)
        //            {
        //                flag = false;
        //                break;
        //            }

        //        }
        //    }
        //    if (flag)
        //        Console.WriteLine("Prime number");
        //    else
        //        Console.WriteLine("Not prime number");
        //}

        //void CheckPalindrome(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        Console.WriteLine("Empty string ");
        //    else
        //    {
        //        int length = input.Length;
        //        int j = length - 1;
        //        bool flag = true;
        //        for (int i = 0; i < length / 2; i++)
        //        {
        //            if (input[i] != input[j])
        //            {
        //                flag = false;
        //                break;
        //            }
        //            j--;
        //        }
        //        if (flag)
        //            Console.WriteLine("Palindrome string");
        //        else
        //            Console.WriteLine("Not a palindrome string");
        //    }
        //}


        public void PredicateExample()
        {
            //Predicate<int> leapYear = new Predicate<int>(CheckLeapYear);
            //Predicate<int> leapYear = delegate (int year)
            //{
            //    return DateTime.IsLeapYear(year);

            //};



            //lambda creates an anonymous method using delegate
            Predicate<int> leapYear = (year) => DateTime.IsLeapYear(year);




            bool flag = leapYear(2000);
            if (flag)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("not a leap year");

        }
        //bool CheckLeapYear(int year)
        //{
        //    return DateTime.IsLeapYear(year);
        //}


        public void FuncExample()
        {
            // Func<int, string> fibbonaci = new Func<int, string>(GetFibbonaci);

            //Func<int, string> fibbonaci = delegate (int length)
            //{
            //    int a = 0, b = 1, c = 0;
            //    StringBuilder str = new StringBuilder();

            //    for (int i = 0; i < length; i++)
            //    {
            //        str.Append(a + " ");
            //        c = a + b;
            //        a = b;
            //        b = c;
            //    }
            //    return str.ToString();
            //};




            Func<int, string> fibbonaci = (length) =>
           {
               int a = 0, b = 1, c = 0;
               StringBuilder str = new StringBuilder();
               

               for (int i = 0; i < length; i++)
               {
                   str.Append(a + " ");
                   c = a + b;
                   a = b;
                   b = c;
               }
               return str.ToString();
           };




            string result = fibbonaci(7);
            Console.WriteLine(result);
        }
        //string GetFibbonaci(int length)
        //{
        //    int a = 0, b = 1, c = 0;
        //    string str = "";
        //    for (int i = 0; i < length; i++)
        //    {
        //        str = str + a + " ";
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    return str;
        //}



    }
}
