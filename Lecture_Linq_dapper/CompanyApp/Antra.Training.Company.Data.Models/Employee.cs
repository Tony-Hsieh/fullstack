using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.Training.Company.Data.Models
{
  public  class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
    }
}
