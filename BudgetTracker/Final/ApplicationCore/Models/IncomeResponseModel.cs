using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class IncomeResponseModel
    {
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime? IncomeDate { get; set; }
        public string Remarks { get; set; }

        
    }
}