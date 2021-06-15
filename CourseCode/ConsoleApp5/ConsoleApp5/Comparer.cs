using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Comparer<T> where T : class
    {

        //public bool CheckEquality(object a, object b)
        //{
        //    /*
        //     * 1. typesafety
        //     * 2. unwanted boxing and unboxing is happening
        //     * 
        //     *      boxing:- conversion of value type to reference type is boxing
        //     *      unboxing:- coversion of reference type to value type
        //     * 
        //     */
        //    return a.Equals(b);
        //}

        public bool CheckEquality(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
