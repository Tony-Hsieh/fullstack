using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Models
{
    public class UserDetailsResponseModel
    {
        public int UserId { get; set; }
        
        public string FullName { get; set; }
        
        
        public List<Income> Incomes { get; set; }
        public List<Expenditure> Expenditures { get; set; }
    }
}