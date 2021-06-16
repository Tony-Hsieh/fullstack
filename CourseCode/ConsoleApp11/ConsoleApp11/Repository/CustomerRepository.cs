using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp11.Model;
namespace ConsoleApp11.Repository
{
    public class CustomerRepository
    {
        List<Customer> lstCustomer = new List<Customer> {
         new Customer(){ Id=1, Name="Smith", City="Paris", Country="France"},
         new Customer(){ Id=2, Name="Peter", City="Sterling", Country="USA"},
         new Customer(){ Id=3, Name="John", City="Dallas", Country="USA"},
         new Customer(){ Id=4, Name="Rhea", City="Wales", Country="UK"},
         new Customer(){ Id=5, Name="Maria", City="Birmingum", Country="UK"},
         new Customer(){ Id=6, Name="Willaim", City="Chicago", Country="USA"},


        };


        public IEnumerable<Customer> GetDataBySearch(Predicate<Customer> del)
        {
            List<Customer> result = new List<Customer>();
            foreach (Customer item in lstCustomer)
            {
                if (del(item))
                    result.Add(item);
            }
            return result;
        }


        //public IEnumerable<Customer> GetAll()
        //{
        //    return lstCustomer;
        //}
        //public IEnumerable<Customer> GetByCity(string city)
        //{
        //    List<Customer> result = new List<Customer>();
        //    foreach (Customer item in lstCustomer)
        //    {
        //        if (item.City == city)
        //            result.Add(item);
        //    }
        //    return result;
        //}

        //public IEnumerable<Customer> GetByCountry(string country)
        //{
        //    List<Customer> result = new List<Customer>();
        //    foreach (Customer item in lstCustomer)
        //    {
        //        if (item.Country == country)
        //            result.Add(item);
        //    }
        //    return result;

        //}


        //public IEnumerable<Customer> GetByName(string name)
        //{
        //    List<Customer> result = new List<Customer>();
        //    foreach (Customer item in lstCustomer)
        //    {
        //        if (item.Name == name)
        //            result.Add(item);
        //    }
        //    return result;
        //}


        //public IEnumerable<Customer> GetByNameAndCity(string name, string city)
        //{
        //    List<Customer> result = new List<Customer>();
        //    foreach (Customer item in lstCustomer)
        //    {
        //        if (item.Name == name && item.City == city)
        //            result.Add(item);
        //    }
        //    return result;
        //}


    }
}
