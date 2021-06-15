using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class ManageEmployee
    {
        public void AddEmployee()
        {
            try
            {
                Employee emp = new Employee();
                Console.Write("Enter Id = ");
                emp.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter age = ");
                emp.Age = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numbers are allowed");
                //Console.WriteLine(fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("value must be between 1 to " + int.MaxValue);
                // Console.WriteLine(oe.Message);
            }
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Something important code here");
                Console.WriteLine("This is finally");
                // close the connection here
                //remove object from memory
            }
        }


    }

    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 20 || value > 60)
                    throw new AgeException();
                age = value;
            }
        }
    }
}
