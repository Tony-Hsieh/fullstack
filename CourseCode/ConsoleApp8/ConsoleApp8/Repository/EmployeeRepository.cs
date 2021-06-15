using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp8.Model;
namespace ConsoleApp8.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        List<Employee> lstCollection;
        public EmployeeRepository()
        {
            lstCollection = new List<Employee>();
        }

        public int Delete(int id)
        {
            Employee e = GetById(id);
            if (e != null)
            {
                lstCollection.Remove(e);
                return 1;
            }
            return 0;
        }

        public IEnumerable<Employee> GetAll()
        {
            return lstCollection;
        }

        public Employee GetById(int id)
        {
            foreach (Employee e in lstCollection)
            {
                if (e.Id == id)
                    return e;
            }
            return null;
        }

        public int Insert(Employee item)
        {
            lstCollection.Add(item);
            return 1;
        }

        public int Update(Employee item)
        {
            // update Employee set name='smith', salary=7800, department ='IT' where id=3;
            Employee e = GetById(item.Id);
            if (e != null)
            {
                e.Name = item.Name;
                e.Salary = item.Salary;
                e.Department = item.Department;
                return 1;
            }
            return 0;
        }
    }
}
