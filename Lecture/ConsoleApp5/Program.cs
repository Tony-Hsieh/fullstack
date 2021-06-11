using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparer c = new Comparer();
            //Console.WriteLine(c.CheckEquality("abc", 123));
            ////Console.WriteLine(c.CheckEquality<int>("abc", 123));

            //Comparer_T<int> ct = new Comparer_T<int>();
            //ct.CheckEquality(2, 5);

            ManageStudent m = new ManageStudent();
            m.Run();


        }
    }
}
