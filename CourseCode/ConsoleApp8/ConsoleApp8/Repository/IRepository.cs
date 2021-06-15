using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Repository
{
    public interface IRepository<T> where T : class
    {
        int Insert(T item);
        int Delete(int id);
        int Update(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
