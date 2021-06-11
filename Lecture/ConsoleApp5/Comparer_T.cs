using System;
namespace ConsoleApp5
{
    public class Comparer_T <T> //where T: class
    {
        public bool CheckEquality(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
