using System;
namespace ConsoleApp1.Model
{
    public class Employee
    {
        public Employee()
        {
        }

        private int id;
        private string fullName;
        private double salary;
        private int deptId;
        private string mobile;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public int DeptId
        {
            get
            {
                return deptId;
            }
            set
            {
                deptId = value;
            }
        }

        public String Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

    }
}
