using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class UserRequestModel
    {
        public int Id { get; set; }
        
        [EmailAddress]
        public String Email { get; set; }
        
        [StringLength (10)]
        public String Password { get; set; }
        
        public String? Fullname { get; set; }
        public DateTime? JoinOn { get; set; }
    }
}