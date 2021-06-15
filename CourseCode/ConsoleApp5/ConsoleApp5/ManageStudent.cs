using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ManageStudent
    {
        List<string> studentCollection = new List<string>();
        List<string> countries = new List<string> { "USA","China","Russia","Germany","Italy"};
        void AddStudent()
        {
            studentCollection.Add("Hao Fu");
            studentCollection.Add("Jinyang Chen");
            studentCollection.Add("Andrew Yuan");
            studentCollection.Insert(1, "Kim");
            studentCollection.Add("Bo Zhou");
        }
        void PrintStudents()
        {
            int length = studentCollection.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(studentCollection[i]);
            }
        }

        void DeleteStudent()
        {
            studentCollection.Remove("Kim");
            studentCollection.RemoveAt(2);
        }

        public void Run()
        {
            AddStudent();
            DeleteStudent();
            PrintStudents();
        }
    }
}
