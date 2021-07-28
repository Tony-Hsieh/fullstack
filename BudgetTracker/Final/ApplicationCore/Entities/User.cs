using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        
        [MaxLength(50)]
        public string FullName { get; set; }
        public String Salt { get; set; }
        
        public DateTime? JoinedOn { get; set; }

        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expenditure> Expenditures { get; set; }
    }
}