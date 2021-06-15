using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparer<int> c = new Comparer<int>();
            //c.CheckEquality(2, 6);
            //Comparer<string> c1 = new Comparer<string>();
            //c1.CheckEquality("Hello", "Welcome");

            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Run();
        }
    }
}
