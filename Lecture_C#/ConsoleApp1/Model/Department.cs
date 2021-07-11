using System;
namespace ConsoleApp1.Model
{
    public class Department
    {
        public Department()
        {
        }

        public int Id { get; internal set; }
        public string DName { get; internal set; }
        public string Location { get; internal set; }
    }
}
