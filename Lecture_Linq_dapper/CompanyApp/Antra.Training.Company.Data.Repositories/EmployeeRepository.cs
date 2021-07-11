using System;
using System.Collections.Generic;
using System.Data;
using Antra.Training.Company.Data.Models;
namespace Antra.Training.Company.Data.Repositories
{
    class EmployeeRepository : IRepository<Employee>
    {
        CompanyDBContext db;
        public EmployeeRepository()
        {
            db = new CompanyDBContext();
        }
        public int Delete(int id)
        {
            string cmd = "Delete from Employee where id=@id";
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("@id", id);
            return db.ExecuteDMLStatements(cmd, p);
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee obj)
        {
            string cmd = "Insert into Employee values (@EName, @Salary,@DeptId)";
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("@EName", obj.EName);
            p.Add("@Salary", obj.Salary);
            p.Add("@DeptId", obj.DeptId);
            return db.ExecuteDMLStatements(cmd, p);
        }

        public int Update(Employee obj)
        {
            string cmd = "spUpdateEmployee";
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("@EName", obj.EName);
            p.Add("@Salary", obj.Salary);
            p.Add("@DeptId", obj.DeptId);
            p.Add("@id", obj.Id);
            return db.ExecuteDMLStatements(cmd, p, CommandType.StoredProcedure);
        }
    }
}
