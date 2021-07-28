using System;
using System.Collections;

namespace ApplicationCore.Models
{
    public class UserResponseModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? JoinedOn { get; set; }
        
    }
}