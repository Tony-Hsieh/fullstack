using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using Antra.DapperTraining.Data.Models;
namespace Antra.Dapper.Data.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        CompanyDBContext db;
        public EmployeeRepository()
        {
            db = new CompanyDBContext();
        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            IDbConnection conn = db.GetConnection();
            
            string cmd = @"select e.Id, e.EName, e.Salary, e.DeptId,d.Id, d.DName,d.Loc  from  Employee e inner join Dept d on e.deptid=d.id";
            return conn.Query<Employee, Dept, Employee>(cmd, (e, d) => { e.Dept = d; return e; });
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
