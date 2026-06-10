using System; 
using System.Collections.Generic; 

namespace ECommerce.Data.Entities
{
    public class User
    {
        public int Id {get; set;}
        public string Email {get; set;} = string.Empty; 
        public string PasswordHash {get; set;} = string.Empty; 
        public string FirstName {get; set;} = string.Empty; 
        public string LastName {get; set;} = string.Empty; 
        public string Role { get; set; } = string.Empty;

        public DateTime CreatedAt {get; set;}
        public List<Order> Orders { get; set; } = new List<Order>();

        
    }
}