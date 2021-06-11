using System;
namespace ConsoleApp5
{
    public class Comparer
    {
        //public bool CheckEquality(int a, int b)
        //{
        //    return a.Equals(b);
        //}
        //public bool CheckEquality(double a, double b)
        //{
        //    return a.Equals(b);
        //}
        public bool CheckEquality(Object a, Object b) //Object is the base type of every class
        {

            /*
             * 1.typesafety
             * 2.unwanted boxing and unboxing is happening
             *  
             */
            return a.Equals(b);
        }
        public bool CheckEquality<T> (T a, T b)
        {
            return a.Equals(b);
        }
    }
}
