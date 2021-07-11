using System;
using System.Collections.Generic;
using System.Text;
using Antra.DapperTraining.Data.Models;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace Antra.Dapper.Data.Repository
{
    public class DeptRepository : IRepository<Dept>, IRepositoryAsync<Dept>
    {
        CompanyDBContext db;
        public DeptRepository()
        {
            db = new CompanyDBContext();
        }

        public int Delete(int id)
        {
            IDbConnection conn = db.GetConnection();
            return conn.Execute("Delete from Dept where Id = @deptid", new { deptid = id });
        }

        public Task<int> DeleteAsync(Dept obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dept> GetAll()
        {
            IDbConnection conn = db.GetConnection();
            return conn.Query<Dept>("Select Id, DName, Loc from Dept");
        }

        public async Task<IEnumerable<Dept>> GetAllAsync()
        {
            IDbConnection conn = db.GetConnection();
            return await conn.QueryAsync<Dept>("Select Id, DName, Loc from Dept");
        }

        public Dept GetById(int id)
        {
            IDbConnection conn = db.GetConnection();
            return conn.QueryFirstOrDefault<Dept>("Select Id,DName,Loc from Dept where Id=@deptId", new { deptId = id });
        }

        public async Task<Dept> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Dept obj)
        {
            IDbConnection conn = db.GetConnection();
            // return conn.Execute("Insert into Dept values (@name,@location)", new { name = obj.DName, location = obj.Loc });
            return conn.Execute("Insert into Dept values (@DName, @Loc)", obj);
        }

        public async Task<int> InsertAsync(Dept obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Dept obj)
        {
            IDbConnection conn = db.GetConnection();
            return conn.Execute("Update Dept set DName =@DName, Loc=@Loc where Id=@Id", obj);
        }

        public async Task<int> UpdateAsync(Dept obj)
        {
            throw new NotImplementedException();
        }


    }
}
