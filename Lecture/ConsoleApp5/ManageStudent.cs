using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class ManageStudent
    {
        List<string> studentCollection = new List<string>();
        List<string> country = new List<string> { "taiwan", "usa"};

        void AddStudent()
        {
            studentCollection.Add("Hao");
            studentCollection.Add("Hao h");
            studentCollection.Add("Hao hhh");
            studentCollection.Insert(1, "Hao hao");
        }
        void Print()
        {
            int length = studentCollection.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(studentCollection[i]);
            }

            foreach(string name in studentCollection) //foreach can be used on every type that inherits IEnumerable interface.
            {
                Console.WriteLine(name);
            }
        }

        void DeleteStudent()
        {
            studentCollection.Remove("Hao");
            studentCollection.RemoveAt(1);
        }

        public void Run()
        {
            AddStudent();
            DeleteStudent();
            Print();
        }

    }
}
