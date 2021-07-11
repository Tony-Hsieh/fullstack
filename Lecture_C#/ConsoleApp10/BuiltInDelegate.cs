using System;
using System.Text;
namespace ConsoleApp10
{
    public class BuiltInDelegate
    {
        /*
         * Action: action can take any generic input parameter but returns void
         * Predicate: it can take any generic input and returns bool value
         * FUnc: it can take any generic input value and return any generic output.
         */

        public void ActionExample()
        {
            Action<int> primeNumber = new Action<int>(CheckPrime);
            primeNumber(37);

            Action<int> primeNumber2 = delegate (int number)
            { //anonymous mothod: method without name
                bool flag = true;
                if (number > 0 && number < 4)
                    flag = true;
                else
                    for (int i = 2; i < number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            flag = false;
                            break;
                        }

                    }
                if (flag)
                    Console.WriteLine("Prime Numebr");
                else
                    Console.WriteLine("Not Prime Numebr");
            };
            primeNumber(37);
        }
        void CheckPrime(int number)
        {
            bool flag = true;
            if (number > 0 && number < 4)
                flag = true;
            else
                for (int i = 2; i < number / 2; i++)
                {
                    if(number % i == 0)
                    {
                        flag = false;
                        break;
                    }
                    
                }
            if (flag)
                Console.WriteLine("Prime Numebr");
            else
                Console.WriteLine("Not Prime Numebr");
        }

        public void PredicateExample()
        {
            Predicate<int> leapYear = new Predicate<int>(CheckLeapYear);
            bool flag = leapYear(2000);
            if (flag)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("not a Leap Year");

            //modified
            Predicate<int> leapYear1 = delegate (int year)
            {
                return DateTime.IsLeapYear(year);
            };

            //modified
            Predicate<int> leapYear2 = (year) => //"=>" lambda creates an anonymous method using delegate
            {
                return DateTime.IsLeapYear(year);
            };
            Predicate<int> leapYear3 = (year) => DateTime.IsLeapYear(year);

        }
        bool CheckLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }


        public void FuncExample()
        {
            Func<int, string> fibbonaci = new Func<int, string>(GetFibbonaci);
            string result = fibbonaci(7);
            Console.WriteLine(result);
;
        }
        string GetFibbonaci(int length)
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
        }
    }
}
