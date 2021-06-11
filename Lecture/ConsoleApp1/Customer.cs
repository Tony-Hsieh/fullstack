using System;
namespace ConsoleApp1
{
    public class Customer
    {
        private int id;
        private string name, city;

        public Customer()
        {
        }
        public Customer(int id)
        {
            this.id = id;
        }
        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Customer(int id, string custname, string city) : this(id, custname)
        {
            //this.id = id;
            //this.name = custname;
            this.city = city;
        }
    }
}
