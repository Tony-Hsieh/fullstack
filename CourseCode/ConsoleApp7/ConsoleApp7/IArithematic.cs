using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    /*
     * interface is a contract which gives the methods to be implemented by the derived types.
     * all methods inside an interface are by default public and abstract. (don't use any access modifier and abstract).
     * interface supports mulitple inheritance
     * interface cannot have variables and constructor.
     * interface can not be instantiated.
     * interface are used to write loosely coupled code.
     */
    interface IArithematic
    {
        void Addition(int a, int b);
        void Subtract(int a, int b);
        void Multiply(int a, int b);
    }
}
