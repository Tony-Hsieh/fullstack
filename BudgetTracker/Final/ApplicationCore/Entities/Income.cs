using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    [Table("Income")]
    public class Income
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        
        [MaxLength(100)]
        public string Description { get; set; }
        public DateTime? IncomeDate { get; set; }
        
        [MaxLength(500)]
        public string Remarks { get; set; }
        
        public User User { get; set; }
    }
}