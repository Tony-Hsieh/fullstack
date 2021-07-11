using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample1
{
    class EmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>
            { new Employee() { Id=1, FirstName="Smith", DeptId=1, LastName="William",City="Sterling", Salary=5500},
            new Employee() { Id=2, FirstName="Peter", DeptId=1, LastName="Chen",City="Sterling", Salary=5500},
            new Employee() { Id=3, FirstName="David", DeptId=2, LastName="Zhang",City="Leesburg", Salary=8500},
            new Employee() { Id=4, FirstName="Rohit", DeptId=3, LastName="Sharma",City="Tyson", Salary=6500},
            new Employee() { Id=5, FirstName="Mark", DeptId=2, LastName="Patt",City="Chicago", Salary=7500},
            new Employee() { Id=6, FirstName="John", DeptId=1, LastName="Kott",City="Chicago", Salary=5000}};
        }
    }
}
